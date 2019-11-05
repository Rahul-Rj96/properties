CREATE TABLE [dbo].[People] (
    [Id]        INT          NOT NULL,
    [FirstName] VARCHAR (20) NULL,
    [LastName]  VARCHAR (50) NULL,
    CONSTRAINT [PeopleId] PRIMARY KEY CLUSTERED ([Id] ASC)
);

