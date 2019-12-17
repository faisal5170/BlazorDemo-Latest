================================================================================================
EXECUTE BELOW SCRIPT IN	SQL SERVER AND CHANGE CONNECTION-STRING INSIDE "appsettings.json" FILE.
================================================================================================

CREATE DATABASE [BlazorCRUD]

GO
USE [BlazorCRUD]
GO

CREATE TABLE [dbo].[Article](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Article] PRIMARY KEY CLUSTERED 
	(
	[ID] ASC
	)
)

INSERT [dbo].[Article] ([Title]) VALUES (N'The Code Hubs')
GO
INSERT [dbo].[Article] ([Title]) VALUES (N'Faisal')
GO
INSERT [dbo].[Article] ([Title]) VALUES (N'Sort Table')
GO
INSERT [dbo].[Article] ([Title]) VALUES (N'Abc')
GO
INSERT [dbo].[Article] ([Title]) VALUES (N'Test Article')
GO
INSERT [dbo].[Article] ([Title]) VALUES (N'C# Corner')
GO

CREATE PROCEDURE [dbo].[SP_Add_Article]    
    @Title NVARCHAR(250) 
AS    
    BEGIN    
 DECLARE @Id as BIGINT  
        INSERT  INTO [Article]    
                (Title
             )    
        VALUES  ( @Title       
             );   
		SET @Id = SCOPE_IDENTITY();   
        SELECT  @Id AS ArticleID;    
    END;   
GO	
	
CREATE PROCEDURE [dbo].[SP_Update_Article] 
		@Id INT,   
		@Title NVARCHAR(250)   
	AS    
		BEGIN    

		UPDATE [Article] SET Title = @Title WHERE ID = @Id 
	           
		END;    
