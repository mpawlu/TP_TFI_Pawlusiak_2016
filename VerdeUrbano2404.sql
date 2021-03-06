USE [VerdeUrbano]
GO
/****** Object:  Table [dbo].[Leyenda]    Script Date: 04/24/2016 23:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leyenda](
	[ID_Leyenda] [nvarchar](200) NOT NULL,
	[Leyenda] [nvarchar](500) NOT NULL,
	[DVH] [nvarchar](500) NULL,
 CONSTRAINT [PK_Leyenda] PRIMARY KEY CLUSTERED 
(
	[ID_Leyenda] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'btnActualizarIdioma', N'Actualizar Idioma', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Ingresar', N'Ingresar', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Inicio', N'Inicio', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Institucional', N'Institucional', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Nuestros Productos', N'Nuestros Productos', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Quienes Somos', N'Quienes Somos', N'asd')
/****** Object:  Table [dbo].[Idioma]    Script Date: 04/24/2016 23:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[ID_Idioma] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[DVH] [nvarchar](500) NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[ID_Idioma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Idioma] ON
INSERT [dbo].[Idioma] ([ID_Idioma], [Descripcion], [DVH]) VALUES (1, N'Español', NULL)
INSERT [dbo].[Idioma] ([ID_Idioma], [Descripcion], [DVH]) VALUES (3, N'Ingles', N'asd')
INSERT [dbo].[Idioma] ([ID_Idioma], [Descripcion], [DVH]) VALUES (4, N'Portugues', N'asd')
INSERT [dbo].[Idioma] ([ID_Idioma], [Descripcion], [DVH]) VALUES (5, N'Portugues2', N'asd')
INSERT [dbo].[Idioma] ([ID_Idioma], [Descripcion], [DVH]) VALUES (6, N'Portugues3', N'asd')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
/****** Object:  StoredProcedure [dbo].[s_Leyenda_ListarTodas]    Script Date: 04/24/2016 23:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Leyenda_ListarTodas] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Leyenda
END
GO
/****** Object:  StoredProcedure [dbo].[s_Idioma_ListarTodos]    Script Date: 04/24/2016 23:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Idioma_ListarTodos]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * 
	From Idioma
END
GO
/****** Object:  StoredProcedure [dbo].[s_Idioma_Crear]    Script Date: 04/24/2016 23:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Idioma_Crear]
	-- Add the parameters for the stored procedure here
	@Descripcion nvarchar(50),
	@DVH nvarchar(500) 
AS
BEGIN
	--SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Idioma(Descripcion, DVH) values (@Descripcion, @DVH)
END
GO
/****** Object:  StoredProcedure [dbo].[s_Idioma_Consultar]    Script Date: 04/24/2016 23:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Idioma_Consultar]			
	-- Add the parameters for the stored procedure here
	@ID_Idioma int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	ID_Idioma,
	Descripcion
	From Idioma
	where ID_Idioma = @ID_Idioma
END
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 04/24/2016 23:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [nvarchar](100) NOT NULL,
	[Pass] [nvarchar](500) NOT NULL,
	[DNI] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
	[Perfil] [int] NOT NULL,
	[Bloqueado] [bit] NOT NULL,
	[FechaAlta] [date] NOT NULL,
	[Editable] [bit] NOT NULL,
	[Intentos] [int] NULL,
	[ID_Idioma] [int] NOT NULL,
	[DVH] [nvarchar](500) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Pass], [DNI], [Activo], [Perfil], [Bloqueado], [FechaAlta], [Editable], [Intentos], [ID_Idioma], [DVH]) VALUES (4, N'admin', N'21232F297A57A5A743894A0E4A801FC3', 34713868, 0, 1, 0, CAST(0x493B0B00 AS Date), 0, 0, 3, N'ASFDDFD')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
/****** Object:  Table [dbo].[Traduccion]    Script Date: 04/24/2016 23:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[ID_Leyenda] [nvarchar](200) NOT NULL,
	[ID_Idioma] [int] NOT NULL,
	[Traduccion] [nvarchar](500) NOT NULL,
	[DVH] [nvarchar](500) NULL,
 CONSTRAINT [PK_Traduccion] PRIMARY KEY CLUSTERED 
(
	[ID_Leyenda] ASC,
	[ID_Idioma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'btnActualizarIdioma', 1, N'Actualizar Idioma', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'btnActualizarIdioma', 3, N'Update Language', N'dd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Ingresar', 1, N'Ingresar', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Ingresar', 3, N'Sign In', N'asdsd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Inicio', 1, N'Inicio', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Inicio', 3, N'Home', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Institucional ', 1, N'Institucional', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Institucional', 3, N'Our Company', N'sdf')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Nuestros Productos', 1, N'Nuestros Productos', N'sad')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Nuestros Productos', 3, N'Products', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Quienes Somos', 1, N'Quienes Somos', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Quienes Somos', 3, N'About Us', N'asds')
/****** Object:  StoredProcedure [dbo].[s_Usuario_Modificar]    Script Date: 04/24/2016 23:47:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Usuario_Modificar]
	-- Add the parameters for the stored procedure here
	@ID_Usuario int,
	@NombreUsuario nvarchar(50),
	@Pass nvarchar(500),
	@DNI int,
	@Activo bit,
	@Perfil int,
	@Bloqueado bit,
	@FechaAlta date,
	@Editable bit,
	@Intentos int,
	@ID_Idioma int,
	@DVH nvarchar(500)
	
AS
BEGIN
	--SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
   UPDATE Usuario
   SET [NombreUsuario] = @NombreUsuario,
       [Pass] = @Pass,
       [DNI] = @DNI,
       [Activo]= @Activo,
       [Perfil]= @Perfil,
       [Bloqueado]= @Bloqueado,
       [FechaAlta]= @FechaAlta,
       [Editable]= @Editable,
       [Intentos] = @Intentos,
       [ID_Idioma]= @ID_Idioma,
       [DVH]= @DVH

        WHERE ID_Usuario=@ID_Usuario
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_ListarTodos]    Script Date: 04/24/2016 23:47:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Usuario_ListarTodos]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	--SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		ID_Usuario,
		NombreUsuario,
		Pass,
		DNI,
		Activo,
		Perfil,
		Bloqueado,
		FechaAlta,
		Editable,
		Intentos,
		Usuario.ID_Idioma,
		Idioma.Descripcion

	FROM	Usuario, Idioma

	
	WHERE	Idioma.ID_Idioma = Usuario.ID_Idioma 
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_Crear]    Script Date: 04/24/2016 23:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Usuario_Crear]
	-- Add the parameters for the stored procedure here
	@NombreUsuario nvarchar(100),
	@Pass nvarchar(500),
	@DNI int,
	@Activo bit,
	@Perfil int,
	@Bloqueado bit,
	@FechaAlta date,
	@Editable bit,
	@Intentos int,
	@ID_Idioma int,
	@DVH nvarchar(500)
	
AS
BEGIN
	--SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Usuario
	(NombreUsuario, Pass, DNI, Activo, Perfil, Bloqueado, FechaAlta, Editable, Intentos, ID_Idioma, DVH)
     VALUES
    (@NombreUsuario, @Pass, @DNI, @Activo, @Perfil, @Bloqueado, @FechaAlta, @Editable, @Intentos, @ID_Idioma, @DVH)
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_Consultar_PorNombre]    Script Date: 04/24/2016 23:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Usuario_Consultar_PorNombre]
	-- Add the parameters for the stored procedure here
	@NombreUsuario varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	ID_Usuario,
		NombreUsuario,
		Pass,
		DNI,
		Activo,
		Perfil,
		Bloqueado,
		FechaAlta,
		Editable,
		Intentos,
		ID_Idioma
		
	from Usuario
	where usuario.NombreUsuario = @NombreUsuario 
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_Consultar]    Script Date: 04/24/2016 23:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Usuario_Consultar]
	-- Add the parameters for the stored procedure here
	@ID_Usuario int
	
AS
BEGIN
	--SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		ID_Usuario,
		NombreUsuario,
		Pass,
		DNI,
		Activo,
		Perfil,
		Bloqueado,
		FechaAlta,
		Editable,
		Intentos,
		Usuario.ID_Idioma,
		Idioma.Descripcion

	FROM	Usuario, Idioma

	
	WHERE	Usuario.ID_USUARIO = @ID_Usuario and Idioma.ID_Idioma = Usuario.ID_Idioma 
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_ChequearUsuario]    Script Date: 04/24/2016 23:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Usuario_ChequearUsuario]
	-- Add the parameters for the stored procedure here
	@NombreUsuario varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	ID_Usuario,
		NombreUsuario,
		Pass,
		DNI,
		Activo,
		Perfil,
		Bloqueado,
		FechaAlta,
		Editable,
		Intentos,
		Usuario.ID_Idioma
		
	from Usuario
	where usuario.NombreUsuario = @NombreUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_Baja]    Script Date: 04/24/2016 23:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Usuario_Baja]
	-- Add the parameters for the stored procedure here
	@ID_Usuario int,
	@Activo bit
	
AS
BEGIN
	--SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
   UPDATE Usuario
   SET 
       [Activo]= @Activo

        WHERE ID_Usuario=@ID_Usuario
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Traduccion_ListarPorIdioma]    Script Date: 04/24/2016 23:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Traduccion_ListarPorIdioma]
	-- Add the parameters for the stored procedure here

	@ID_Idioma int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	    select
    Traduccion.ID_Idioma,
    Idioma.Descripcion,
	Traduccion.ID_Leyenda,
	Leyenda.Leyenda,
	Traduccion.Traduccion
	
	FROM Traduccion, Idioma, Leyenda
	
	where Traduccion.ID_Idioma = Idioma.ID_Idioma and traduccion.ID_Leyenda = Leyenda.ID_Leyenda
	and Traduccion.ID_Idioma = @ID_Idioma and Traduccion.ID_Idioma =  @ID_Idioma 
END
GO
/****** Object:  StoredProcedure [dbo].[s_Traduccion_Crear]    Script Date: 04/24/2016 23:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Traduccion_Crear]			
	-- Add the parameters for the stored procedure here
	@ID_Idioma int,
	@ID_Leyenda int,
	@traduccion varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Traduccion(ID_Idioma, ID_Leyenda, Traduccion) values (@ID_Idioma, @ID_Leyenda, @Traduccion)
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Traduccion_Consultar]    Script Date: 04/24/2016 23:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Traduccion_Consultar]
	-- Add the parameters for the stored procedure here

@ID_Idioma int,
@ID_Leyenda nvarchar
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select
    Traduccion.ID_Idioma,
    Idioma.Descripcion,
	Traduccion.ID_Leyenda,
	Leyenda.Leyenda,
	Traduccion.Traduccion
	
	FROM Traduccion, Idioma, Leyenda
	
	where Traduccion.ID_Idioma = Idioma.ID_Idioma and traduccion.ID_Leyenda = Leyenda.ID_Leyenda
	and Traduccion.ID_Idioma = @ID_Idioma and Traduccion.ID_Leyenda like + '%' +  @ID_Leyenda + '%'
END
GO
/****** Object:  ForeignKey [FK_Traduccion_Idioma]    Script Date: 04/24/2016 23:47:38 ******/
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Idioma] FOREIGN KEY([ID_Idioma])
REFERENCES [dbo].[Idioma] ([ID_Idioma])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Idioma]
GO
/****** Object:  ForeignKey [FK_Traduccion_Leyenda]    Script Date: 04/24/2016 23:47:38 ******/
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Leyenda] FOREIGN KEY([ID_Leyenda])
REFERENCES [dbo].[Leyenda] ([ID_Leyenda])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Leyenda]
GO
/****** Object:  ForeignKey [FK_Usuario_Idioma]    Script Date: 04/24/2016 23:47:38 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Idioma] FOREIGN KEY([ID_Idioma])
REFERENCES [dbo].[Idioma] ([ID_Idioma])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Idioma]
GO
