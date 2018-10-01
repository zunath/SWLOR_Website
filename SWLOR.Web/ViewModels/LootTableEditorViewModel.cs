using System;
using System.Collections.Generic;
using System.Linq;
using DotNetify;
using Microsoft.EntityFrameworkCore;
using SWLOR.Web.Data;
using SWLOR.Web.Data.Entities;
using SWLOR.Web.Models.UI.LootTableEditor;
using SWLOR.Web.Models.Validation;

namespace SWLOR.Web.ViewModels
{
    public class LootTableEditorViewModel: BaseVM
    {
        private readonly DataContext _db;

        public IEnumerable<LootTableOptionUI> LootTableOptions
        {
            get => Get<IEnumerable<LootTableOptionUI>>();
            set => Set(value);
        }

        public int SelectedLootTableID
        {
            get => Get<int>();
            set
            {
                Set(value);
                if (value > 0)
                {
                    ActiveLootTable = _db.LootTables
                        .Include(i => i.LootTableItems)
                        .Single(x => x.LootTableID == SelectedLootTableID);
                }
                    
            }
        }

        private bool _showNotification;
        public bool ShowNotification
        {
            get
            {
                var value = _showNotification;
                _showNotification = false;
                return value;
            }
            set
            {
                _showNotification = value;
                Changed(nameof(ShowNotification));
            }
        }

        public string NotificationMessage
        {
            get => Get<string>();
            set => Set(value);
        }

        public bool NotificationSuccessful
        {
            get => Get<bool>();
            set => Set(value);
        }
        
        public LootTable ActiveLootTable
        {
            get => Get<LootTable>();
            set => Set(value);
        }

        public Action<int> ChangeLootTable => LoadLootTable;

        public Action<int> DiscardChanges => LoadLootTable;

        private void LoadLootTable(int lootTableID)
        {
            if (lootTableID <= -1)
            {
                ActiveLootTable = new LootTable{ LootTableID = lootTableID == -1 ? -1 : -2 };
                return;
            }

            ActiveLootTable = _db.LootTables
                .Include(i => i.LootTableItems)
                .SingleOrDefault(x => x.LootTableID == lootTableID);
        }


        public Action<int> DeleteLootTable => lootTableID =>
        {
            var lt = _db.LootTables
                .Include(i => i.LootTableItems)
                .SingleOrDefault(x => x.LootTableID == lootTableID);
            if (lt == null) return;

            _db.LootTableItems.RemoveRange(lt.LootTableItems);
            _db.LootTables.Remove(lt);

            try
            {
                _db.SaveChanges();
                NotificationMessage = "Loot table '" + lt.Name + "' deleted successfully!";
                NotificationSuccessful = true;
                ShowNotification = true;

                LoadLootTableOptions();
                ActiveLootTable = new LootTable {LootTableID = -1};
            }
            catch (Exception ex)
            {
                NotificationMessage = "Failed to delete loot table '" + lt.Name + "'..." + Environment.NewLine +
                                      "Reason: " + ex.Message;
                NotificationSuccessful = false;
                ShowNotification = true;
            }
        };

        public Action<LootTable> SaveChanges => lootTable =>
        {
            int originalLootTableID = lootTable.LootTableID;

            if (lootTable.LootTableID <= 0)
            {
                lootTable.LootTableID = _db.LootTables.Max(x => x.LootTableID) + 1; ;
            }

            LootTableValidator validator = new LootTableValidator();
            var result = validator.Validate(lootTable);
            if (!result.IsValid)
            {
                NotificationMessage = "Error saving loot table: " + Environment.NewLine + Environment.NewLine;
                foreach (var error in result.Errors)
                {
                    NotificationMessage += error.ErrorMessage + Environment.NewLine;
                }

                NotificationSuccessful = false;
                ShowNotification = true;
                lootTable.LootTableID = originalLootTableID;
                return;
            }

            var lt = _db.LootTables
                        .Include(i => i.LootTableItems)
                        .SingleOrDefault(x => x.LootTableID == lootTable.LootTableID) ?? 
                     new LootTable();
            lt.Name = lootTable.Name;
            lt.LootTableID = lootTable.LootTableID;
            
            _db.LootTableItems.RemoveRange(lt.LootTableItems);
            lt.LootTableItems.Clear();
            foreach (var lti in lootTable.LootTableItems)
            {
                lti.LootTableItemID = 0;
                lti.SpawnRule = lti.SpawnRule ?? string.Empty;
                lt.LootTableItems.Add(lti);
            }

            if (originalLootTableID <= 0)
            {
                _db.LootTables.Add(lt);
            }

            try
            {
                _db.SaveChanges();
                NotificationMessage = "Changes were saved successfully.";
                NotificationSuccessful = true;
                LoadLootTableOptions();
                SelectedLootTableID = lt.LootTableID;
            }
            catch(Exception ex)
            {
                NotificationMessage = "Failed to save changes. Ensure all fields are entered in properly.";
                NotificationSuccessful = false;
            }

            ShowNotification = true;
        };

        private void LoadLootTableOptions()
        {

            var options = _db.LootTables
                .Select(x => new LootTableOptionUI
                {
                    Name = x.Name,
                    LootTableID = x.LootTableID
                }).ToList();

            LootTableOptionUI selectOption = new LootTableOptionUI
            {
                Name = "Select a loot table...",
                LootTableID = -1
            };

            options.Insert(0, selectOption);

            LootTableOptions = options;
        }

        public LootTableEditorViewModel(DataContext db)
        {
            _db = db;

            LoadLootTableOptions();
            SelectedLootTableID = LootTableOptions.First().LootTableID;
        }
        
    }
}
