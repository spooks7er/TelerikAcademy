SELECT SERVERPROPERTY('IsFullTextInstalled')

CREATE FULLTEXT CATALOG Text_Catalog
GO
CREATE FULLTEXT INDEX ON [dbo].[Test] ([Text]) KEY INDEX PK_Test ON [Text_Catalog]
WITH CHANGE_TRACKING AUTO

DBCC DROPCLEANBUFFERS
DBCC FREEPROCCACHE

SELECT [Text] FROM Test
WHERE [Text] like '%565654'