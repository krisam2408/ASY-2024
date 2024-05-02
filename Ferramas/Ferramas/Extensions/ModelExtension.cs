using Microsoft.EntityFrameworkCore;

namespace Ferramas.Extensions;

public static class ModelExtension
{
    #region Repository
    public static async Task InsertAsync<T>(this DbSet<T> dbSet, T instance) where T : class
    {
        if (instance != null && !dbSet.Contains(instance))
            await dbSet.AddAsync(instance);
    }

    public static async Task InsertRangeAsync<T>(this DbSet<T> dbSet, params T[] instances) where T : class
    {
        foreach (T t in instances)
            if (t != null && !dbSet.Contains(t))
                await dbSet.AddAsync(t);
    }

    public static async Task UpdateAsync<T>(this DbSet<T> dbSet, T instance) where T : class
    {
        if (instance != null)
            await dbSet.AddOrUpdateAsync(instance);
    }

    private static async Task AddOrUpdateAsync<T>(this DbSet<T> dbSet, T instance) where T : class
    {
        if (!dbSet.Contains(instance))
        {
            await dbSet.AddAsync(instance);
            return;
        }
        dbSet.Update(instance);
    }

    public static void Delete<T>(this DbSet<T> dbSet, T instance) where T : class
    {
        if (instance != null)
            dbSet.Remove(instance);
    }

    public static void DeleteRange<T>(this DbSet<T> dbSet, T[] array) where T : class
    {
        foreach (T t in array)
            if (t != null)
                dbSet.Remove(t);
    }

    public static bool Contains<T>(this DbSet<T> dbSet, T instance) where T : class
    {
        foreach (T t in dbSet)
            if (t.Equals(instance))
                return true;
        return false;
    }
    #endregion
}
