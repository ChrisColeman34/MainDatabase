CREATE TABLE [dbo].[CoreObjectMetadata]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Metadata] VARCHAR(MAX) NOT NULL, 
    [MetadataType] INT NOT NULL, 
    CONSTRAINT [FK_CoreObjectMetadata_MetadataType] FOREIGN KEY ([MetadataType]) REFERENCES [MetadataType](Id)
)

GO

CREATE INDEX [IX_CoreObjectMetadata_Id] ON [dbo].[CoreObjectMetadata] (Id)
