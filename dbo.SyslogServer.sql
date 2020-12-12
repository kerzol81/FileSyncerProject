CREATE TABLE [dbo].[SyslogServer] (
    [Ip]      VARCHAR (15) DEFAULT '10.0.0.1' NOT NULL,
    [Port]    INT          DEFAULT 514 NOT NULL,
    [Enabled] BIT          DEFAULT 0 NULL, 
    CONSTRAINT [PK_SyslogServer] PRIMARY KEY ([Ip]),
);

