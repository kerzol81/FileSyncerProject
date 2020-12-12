CREATE TABLE [dbo].[Users] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [UserName]  VARCHAR (64) NOT NULL,
    [Password]  VARCHAR (64) NOT NULL,
    [UserLevel] VARCHAR (16) NOT NULL,
);
