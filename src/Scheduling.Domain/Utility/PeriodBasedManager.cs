using NhsWales.Scheduling.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NhsWales.Scheduling.Domain.Utility
{
    public static class PeriodBasedManager
    {
        public static void AddNewEntry<T>(this ICollection<T> entries, T newEntry, Func<T, bool>? filter = null)
        where T : PeriodBased
        {
            var entriesToDeprecate = filter == null
                ? entries.Where(e => e.IsActive)
                : entries.Where(e => e.IsActive && filter(e));

            foreach (var entry in entriesToDeprecate)
            {
                entry.DeprecateEntry();
            }

            entries.Add(newEntry);
        }

        public static T? DuplicateActiveAndAddNewEntry<T>(this ICollection<T> entries, Action<T>? propertyUpdates = null, Func<T, bool>? filter = null) where T : PeriodBased, new()
        {
            var activeFiltereredEntities = filter == null
                                            ? entries.Where(e => e.IsActive)
                                            : entries.Where(e => e.IsActive && filter(e));

            //There should only ever be one, but if multiple, nab the one with the latest start date
            var latestEntry = activeFiltereredEntities
                                .OrderByDescending(e => e.PeriodStart ?? DateTime.MinValue)
                                .FirstOrDefault();
            if (latestEntry == null)
                return null;

            foreach (var entry in activeFiltereredEntities)
            {
                entry.DeprecateEntry();
            }

            var newEntry = new T();

            CopyProperties(latestEntry, newEntry);

            newEntry.PeriodStart = DateTime.UtcNow;
            newEntry.PeriodEnd = null;

            propertyUpdates?.Invoke(newEntry);

            entries.Add(newEntry);

            return newEntry;
        }

        private static void CopyProperties<T>(T source, T target) where T : PeriodBased
        {
            var type = typeof(T);
            foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                     .Where(p => p.CanWrite && p.Name != nameof(PeriodBased.PeriodStart)
                                                 && p.Name != nameof(PeriodBased.PeriodEnd)))
            {
                var value = prop.GetValue(source);
                prop.SetValue(target, value);
            }
        }
    }
}
