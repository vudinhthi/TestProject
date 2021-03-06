USE [Northwind]
GO
/****** Object:  StoredProcedure [dbo].[SP_GETCATEGORIES]    Script Date: 3/8/2020 7:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GETCATEGORIES]
	-- Add the parameters for the stored procedure here	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Categories
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GETPRODUCTS]    Script Date: 3/8/2020 7:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GETPRODUCTS]
	-- Add the parameters for the stored procedure here	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT pr.*, ca.CategoryName FROM Products pr, Categories ca WHERE pr.CategoryID = ca.CategoryID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GETPRODUCTSBYCATEGORY]    Script Date: 3/8/2020 7:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GETPRODUCTSBYCATEGORY]
	-- Add the parameters for the stored procedure here
	@CATEGORYID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT pr.*, ca.CategoryName FROM Products pr, Categories ca WHERE pr.CategoryID = ca.CategoryID AND pr.CategoryID=ca.CategoryID
END
GO
