CREATE TABLE [dbo].[Country] (
    [CountryID] 	INT           	NOT NULL,
    [Name]        	NVARCHAR (60) 	NULL,
    [Code]     		CHAR (2)    		NULL,  
    CONSTRAINT [PK_Country] PRIMARY KEY ([CountryID]),    
)

CREATE TABLE [dbo].[Coach] (
    [CoachID] 		INT           	NOT NULL,
    [Name]        	NVARCHAR (60) 	NULL,
    [Age]     		INT     		NULL,  
    CONSTRAINT [PK_Coach] PRIMARY KEY ([CoachID]),    
)

CREATE TABLE [dbo].[Judge] (
    [JudgeID] 		INT           	NOT NULL,
    [Name]        	NVARCHAR (60) 	NULL,
	[Age]     		INT     		NULL,
    [CountryFK] 	INT 			NULL,
	CONSTRAINT [FK_Judge_ToCountry] FOREIGN KEY ([CountryFK]) REFERENCES [dbo].[Country] ([CountryID]),  
    CONSTRAINT [PK_Judge] PRIMARY KEY ([JudgeID]),    
)

CREATE TABLE [dbo].[Competitor] (
    [CompetitorID] 	INT           	NOT NULL,
    [Name]        	NVARCHAR (60) 	NULL,
    [Age]     		INT     		NULL, 
	[Gender]     	CHAR(1)     	NULL, 
	[Height]     	INT    			NULL, 
	[CountryFK] 	INT 			NULL,
	CONSTRAINT [FK_Competitor_ToCountry] FOREIGN KEY ([CountryFK]) REFERENCES [dbo].[Country] ([CountryID]),
    CONSTRAINT [PK_Competitor] PRIMARY KEY ([CompetitorID]),    
)

CREATE TABLE [dbo].[Competition] (
    [CompetitionID]     INT            	NOT NULL,
    [Name]   			NVARCHAR (60)  	NULL,
    [Type]            	NVARCHAR (20) 	NULL,
    [Date]             	DateTime     	NULL, 
	[CountryFK] 		INT 			NULL, 
	[JudgeFK1] 			INT 			NULL,
	[JudgeFK2] 			INT 			NULL,
	[JudgeFK3] 			INT 			NULL,
	[JudgeFK4] 			INT 			NULL,
	[JudgeFK5] 			INT 			NULL,
	CONSTRAINT [FK_Competition_ToCountry] FOREIGN KEY ([CountryFK]) REFERENCES [dbo].[Country] ([CountryID]),
	CONSTRAINT [FK_Competition_ToJudge1] FOREIGN KEY ([JudgeFK1]) REFERENCES [dbo].[Judge] ([JudgeID]),
	CONSTRAINT [FK_Competition_ToJudge2] FOREIGN KEY ([JudgeFK2]) REFERENCES [dbo].[Judge] ([JudgeID]),
	CONSTRAINT [FK_Competition_ToJudge3] FOREIGN KEY ([JudgeFK3]) REFERENCES [dbo].[Judge] ([JudgeID]),
	CONSTRAINT [FK_Competition_ToJudge4] FOREIGN KEY ([JudgeFK4]) REFERENCES [dbo].[Judge] ([JudgeID]),
	CONSTRAINT [FK_Competition_ToJudge5] FOREIGN KEY ([JudgeFK5]) REFERENCES [dbo].[Judge] ([JudgeID]),
    CONSTRAINT [PK_Competition] PRIMARY KEY ([CompetitionID]),    
)

CREATE TABLE [dbo].[Couple] (
    [CoupleSK]    		INT IDENTITY (1, 1) NOT NULL,
    [FemaleCompetitorFK]  	INT NULL,
    [MaleCompetitorFK] 	INT NULL,
	[CoachFK] 			INT NULL,
	[CountryFK] 		INT NULL,
    CONSTRAINT [FK_Couple_ToCompetitor1] FOREIGN KEY ([FemaleCompetitorFK]) REFERENCES [dbo].[Competitor] ([CompetitorID]),
    CONSTRAINT [FK_Couple_ToCompetitor2] FOREIGN KEY ([MaleCompetitorFK]) REFERENCES [dbo].[Competitor] ([CompetitorID]),
	CONSTRAINT [FK_Couple_ToCoach] FOREIGN KEY ([CoachFK]) REFERENCES [dbo].[Coach] ([CoachID]),
	CONSTRAINT [FK_Couple_ToCountry] FOREIGN KEY ([CountryFK]) REFERENCES [dbo].[Country] ([CountryID]),	
    CONSTRAINT [PK_Couple] PRIMARY KEY ([CoupleSK]) 
)

CREATE TABLE [dbo].[Competition_Couple] (
    [SeasonEventSK]    INT IDENTITY (1, 1) NOT NULL,
    [CoupleFK]  		INT 			NULL,
	[CompetitionFK] INT 			NULL,
	[Rank]     		INT    			NULL,
	CONSTRAINT [FK_SeasonEvent_ToCouple] FOREIGN KEY ([CoupleFK]) REFERENCES [dbo].[Couple] ([CoupleSK]),
	CONSTRAINT [FK_SeasonEvent_ToCompetition] FOREIGN KEY ([CompetitionFK]) REFERENCES [dbo].[Competition] ([CompetitionID]),	
    CONSTRAINT [PK_SeasonEvent] PRIMARY KEY ([SeasonEventSK]) 
)