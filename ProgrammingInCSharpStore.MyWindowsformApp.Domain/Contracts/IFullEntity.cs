namespace ProgrammingInCSharpStore.MyWindowsformApp.Domain.Contracts;

internal interface IFullEntity <T>: IEntity<T>,ICreateableEntity,IDeletableEntity
    {
    }

