CREATE TABLE [dbo].[CoreObjects]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ObjectTypeId] INT NOT NULL, 
    [ObjectName] NVARCHAR(MAX) NOT NULL DEFAULT ' ', 
    [ObjectMetadataId] INT NOT NULL, 
    [VersionId] INT NOT NULL, 
    CONSTRAINT [FK_CoreObjects_CoreObjectType] FOREIGN KEY (ObjectTypeId) REFERENCES [CoreObjectTypes]([Id]), 
    CONSTRAINT [FK_CoreObjects_CoreObjectMetaData] FOREIGN KEY ([ObjectMetadataId]) REFERENCES [CoreObjectMetaData](Id)
)

GO

CREATE INDEX [IX_CoreObjects_Id] ON [dbo].[CoreObjects] (Id)
