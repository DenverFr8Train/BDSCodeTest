﻿CREATE TABLE [dbo].[Task] (
    [TaskID] INT           IDENTITY (1, 1) NOT NULL,
    [TaskNM] NVARCHAR (50) NOT NULL,
    [TaskDT] DATETIME      NOT NULL,
    CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED ([TaskID] ASC)
);

