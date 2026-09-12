namespace ProgrammingInCSharpStore.MyWindowsformApp.Domain.Contracts;



internal interface  IDeletableEntity

 {
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
}

