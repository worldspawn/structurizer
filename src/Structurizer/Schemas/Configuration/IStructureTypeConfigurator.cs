using System;
using System.Linq.Expressions;

namespace Structurizer.Schemas.Configuration
{
    public interface IStructureTypeConfigurator
    {
        IStructureTypeConfig Config { get; }

        IStructureTypeConfigurator OnlyIndexThis(params string[] memberPaths);
        IStructureTypeConfigurator DoNotIndexThis(params string[] memberPaths);
    }

    public interface IStructureTypeConfigurator<T> where T : class
    {
        IStructureTypeConfig Config { get; }

        IStructureTypeConfigurator<T> OnlyIndexThis(params string[] memberPaths);
        IStructureTypeConfigurator<T> OnlyIndexThis(params Expression<Func<T, object>>[] members);
        IStructureTypeConfigurator<T> DoNotIndexThis(params string[] memberPaths);
        IStructureTypeConfigurator<T> DoNotIndexThis(params Expression<Func<T, object>>[] members);
    }
}