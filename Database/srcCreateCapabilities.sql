USE [Samarth]
GO

CREATE TABLE [dbo].[Capability](
	[CapabilityId] [int] IDENTITY(1,1) NOT NULL,
	[Summary] [varchar](50) NULL,
	[TrackId] [int] NULL,
) 
GO

ALTER TABLE [dbo].[Capability]  ADD PRIMARY KEY([TrackId])
GO

ALTER TABLE [dbo].[Capability]  WITH CHECK ADD FOREIGN KEY([TrackId])
REFERENCES [dbo].[Track] ([TrackId])
GO


