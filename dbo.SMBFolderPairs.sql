CREATE TABLE [dbo].[SMBFolderPairs] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [FriendlyName]      VARCHAR (64)  NOT NULL,
    [SourceFolder]      VARCHAR (256) NOT NULL,
    [DestinationFolder] VARCHAR (256) NOT NULL,
    [Added]             DATETIME      NOT NULL,
    [StartSync]         DATETIME      NOT NULL,
    [StopSync]          DATETIME      NOT NULL,
    [DeleteSourceFiles] BIT           DEFAULT ((0)) NOT NULL,
    [Enabled]           BIT           DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

