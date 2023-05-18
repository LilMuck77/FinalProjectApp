using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectApp.Models;
using SQLite;

namespace FinalProjectApp.Data
{
    public class PersonalItemDatabase
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public PersonalItemDatabase()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(PersonalItem).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(PersonalItem)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<PersonalItem>> GetItemsAsync()
        {
            return Database.Table<PersonalItem>().ToListAsync();
        }

        public Task<PersonalItem> GetItemAsync(int id)
        {
            return Database.Table<PersonalItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(PersonalItem item)
        {
            if (item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> InsertList(IEnumerable<PersonalItem> items)
        {
            return Database.InsertAllAsync(items);
        }

        public Task<int> DeleteItemAsync(PersonalItem item)
        {
            return Database.DeleteAsync(item);
        }
        public Task<int> ClearAllAsync()
        {
            return Database.DeleteAllAsync<PersonalItem>();
        }
    }
}
