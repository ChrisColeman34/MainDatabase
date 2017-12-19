CREATE TABLE [dbo].[CoreRelationships]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ObjectIdNodeOne] INT NOT NULL, 
    [ObjectIdNodeTwo] INT NOT NULL, 
    [MetadataId] INT NOT NULL, 
    CONSTRAINT [FK_CoreRelationships_CoreObjectsFirstObject] FOREIGN KEY ([ObjectIdNodeOne]) REFERENCES CoreObjects(Id), 
    CONSTRAINT [FK_CoreRelationships_CoreObjectsSecondObject] FOREIGN KEY ([ObjectIdNodeTwo]) REFERENCES CoreObjects(Id), 
    CONSTRAINT [FK_CoreRelationships_Metadata] FOREIGN KEY ([MetadataId]) REFERENCES CoreObjectMetadata(Id)
)
