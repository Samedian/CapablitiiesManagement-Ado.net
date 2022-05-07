USE [Samarth]
GO

CREATE TABLE [dbo].[Track](
	[TrackId] [int] NOT NULL,
	[TrackName] [varchar](20) NULL,
) 

GO

ALTER TABLE [dbo].[Track]
ADD PRIMARY KEY([TrackId])
Go


