CREATE TABLE [dbo].[FTPFolderPairs] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [FriendlyName]      VARCHAR (64)  NOT NULL,
    [SourceIP]          VARCHAR (16)  NOT NULL,
    [Port]              INT           DEFAULT ((21)) NOT NULL,
    [Passive]           BIT           DEFAULT ((1)) NOT NULL,
    [SharedFolder]     VARCHAR (256) NOT NULL,
    [UserName]          VARCHAR (64)  NOT NULL,
    [PassWord]          VARCHAR (64)  NOT NULL,
    [DestinationFolder] VARCHAR (256) NOT NULL,
    [Added]             DATETIME      NOT NULL,
    [StartSync]         DATETIME      NOT NULL,
    [StopSync]          DATETIME      NOT NULL,
    [DeleteSourceFiles] BIT           DEFAULT ((0)) NOT NULL,
    [Enabled]           BIT           DEFAULT ((1)) NOT NULL, 
    CONSTRAINT [PK_FTPFolderPairs] PRIMARY KEY ([Id]),
);

