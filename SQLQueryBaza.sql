CREATE TABLE Admin(
IdAdmin int identity(1,1) primary key NOT NULL,
UserIdFK int NOT NULL
)
GO

CREATE TABLE RegularUser(
RegularUserId int identity(1,1) primary key NOT NULL,
UserId int NOT NULL
)
GO

CREATE TABLE Book(
ISBN VARCHAR(20) primary key NOT NULL,
DatePublishing  varchar(20) NOT NULL, 
Title          nvarchar(50) NOT NULL, 
BookPublishing varchar(20) NOT NULL
)
GO

CREATE TABLE Author(
AuthorId int identity(1,1) primary key NOT NULL,
ISBNFK VARCHAR(20)
)
GOCREATE TABLE Author(
AuthorId int identity(1,1) primary key NOT NULL,
FirstName varchar(30) NOT NULL,
LastName varchar(30) NOT NULL,
ISBNFK VARCHAR(20)
)
GO

CREATE TABLE AuthorBook(
     AuthorBookId int identity(1,1) primary key NOT NULL, 
     ISBN        varchar(20) NOT NULL,  
     AuthorIdFK   int NOT NULL
)
GO

CREATE TABLE Library(
LibraryId int identity(1,1) primary key NOT NULL,
ISBNFKBook VARCHAR(20)
)
GO

CREATE TABLE Category(
CategoryId int identity(1,1) primary key NOT NULL,
NameCategory    varchar(20) NOT NULL,
ISBNFkCategoryBook VARCHAR(20)
)
GO

CREATE TABLE BookCategory(
     CategoryBookId int identity(1,1) primary key NOT NULL, 
     ISBNFk         varchar(20) NOT NULL,  
     CategoryIdFK   int
)
GO



CREATE TABLE BookLibrary(
    BookLibraryId   int identity(1,1) primary key NOT NULL,
    ISBN            varchar(20) NOT NULL,  
    LibraryId       int NOT NULL   
)
GO