USE [EjemploCapas]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 04/16/2016 00:19:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Localidad](
	[IdLocalidad] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[IdLocalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Localidad] ([IdLocalidad], [Descripcion]) VALUES (1, N'Avellaneda')
INSERT [dbo].[Localidad] ([IdLocalidad], [Descripcion]) VALUES (2, N'Ezeiza ')
INSERT [dbo].[Localidad] ([IdLocalidad], [Descripcion]) VALUES (3, N'Haedo')
INSERT [dbo].[Localidad] ([IdLocalidad], [Descripcion]) VALUES (4, N'Hurlingham')
INSERT [dbo].[Localidad] ([IdLocalidad], [Descripcion]) VALUES (5, N'Caseros')
INSERT [dbo].[Localidad] ([IdLocalidad], [Descripcion]) VALUES (6, N'Lomas del Mirador')
INSERT [dbo].[Localidad] ([IdLocalidad], [Descripcion]) VALUES (7, N'Ituzaingo')
INSERT [dbo].[Localidad] ([IdLocalidad], [Descripcion]) VALUES (9, N'Lanus')
INSERT [dbo].[Localidad] ([IdLocalidad], [Descripcion]) VALUES (10, N'Lomas de Zamora')
INSERT [dbo].[Localidad] ([IdLocalidad], [Descripcion]) VALUES (12, N'Moron')
/****** Object:  Table [dbo].[Leyenda]    Script Date: 04/16/2016 00:19:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leyenda](
	[ID_Leyenda] [nvarchar](200) NOT NULL,
	[Leyenda] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Leyenda] PRIMARY KEY CLUSTERED 
(
	[ID_Leyenda] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda]) VALUES (N'BtnAlta', N'Alta')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda]) VALUES (N'BtnBaja', N'Baja')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda]) VALUES (N'BtnModificar', N'Modificar')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda]) VALUES (N'Button1', N'Boton')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda]) VALUES (N'Inicio', N'Inicio1')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda]) VALUES (N'Institucional', N'Institucional1')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda]) VALUES (N'Institucional1', N'Institucional1-')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda]) VALUES (N'Institucional1.1', N'Institucional1.1-')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda]) VALUES (N'Institucional2', N'Institucional2-')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda]) VALUES (N'Label1', N'Etiqueta')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda]) VALUES (N'lblapellido', N'Apellido')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda]) VALUES (N'lbldni', N'DNI')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda]) VALUES (N'lblidioma', N'Idioma')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda]) VALUES (N'lblnombre', N'Nombre')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda]) VALUES (N'lbllocalidad', N'Localidad')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda]) VALUES (N'Servicios', N'Servicios1')
/****** Object:  Table [dbo].[Idioma]    Script Date: 04/16/2016 00:19:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[ID_Idioma] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[ID_Idioma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Idioma] ON
INSERT [dbo].[Idioma] ([ID_Idioma], [Descripcion]) VALUES (1, N'Español')
INSERT [dbo].[Idioma] ([ID_Idioma], [Descripcion]) VALUES (2, N'Engilsh')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
/****** Object:  StoredProcedure [dbo].[s_Localidades_Listar]    Script Date: 04/16/2016 00:19:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[s_Localidades_Listar]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
    FROM Localidad
END
GO
/****** Object:  StoredProcedure [dbo].[s_Idiomas_Listar]    Script Date: 04/16/2016 00:19:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Idiomas_Listar]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
    FROM Idioma
END
GO
/****** Object:  StoredProcedure [dbo].[s_Idioma_Crear]    Script Date: 04/16/2016 00:19:20 ******/
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
	@Descripcion varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Idioma(Descripcion) values (@Descripcion)
END
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 04/16/2016 00:19:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[DNI] [int] NULL,
	[IdLocalidad] [int] NULL,
	[Activo] [bit] NULL,
	[ID_Idioma] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellido], [DNI], [IdLocalidad], [Activo], [ID_Idioma]) VALUES (1, N'Mariano', N'Pawlusiak', 3454323, 9, 1, 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellido], [DNI], [IdLocalidad], [Activo], [ID_Idioma]) VALUES (2, N'nicolas', N'Pawlusiak', 34543234, 9, 1, 2)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellido], [DNI], [IdLocalidad], [Activo], [ID_Idioma]) VALUES (3, N'Manuel', N'Gimenez', 32343222, 1, 1, 2)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellido], [DNI], [IdLocalidad], [Activo], [ID_Idioma]) VALUES (4, N'Diego', N'Soler', 44345432, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
/****** Object:  Table [dbo].[Traduccion]    Script Date: 04/16/2016 00:19:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[ID_Idioma] [int] NOT NULL,
	[ID_Leyenda] [nvarchar](200) NOT NULL,
	[Traduccion] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Traduccion] PRIMARY KEY CLUSTERED 
(
	[ID_Idioma] ASC,
	[ID_Leyenda] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (1, N'BtnAlta', N'Alta')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (1, N'BtnBaja', N'Baja')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (1, N'BtnModificar', N'Modificar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (1, N'Button1', N'Boton-')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (1, N'Inicio', N'Inicio1')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (1, N'Institucional', N'Institucional1')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (1, N'Institucional1', N'Institucional1-')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (1, N'Institucional1.1', N'Institucional1.1-')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (1, N'Institucional2', N'Institucional2-')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (1, N'Label1', N'Etiqueta-')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (1, N'lblapellido', N'Apellido')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (1, N'lbldni', N'DNI')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (1, N'lblidioma', N'Idioma')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (1, N'lblnombre', N'Nombre')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (1, N'lbllocalidad', N'Localidad')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (1, N'Servicios', N'Servicios1')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (2, N'BtnAlta', N'New')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (2, N'BtnBaja', N'Delete')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (2, N'BtnModificar', N'Update')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (2, N'Button1', N'Button-')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (2, N'Inicio', N'Home')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (2, N'Institucional', N'Our Company')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (2, N'Institucional1', N'Our Company 1-')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (2, N'Institucional1.1', N'Our Company 1.1-')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (2, N'Institucional2', N'Our Company 2-')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (2, N'Label1', N'Label-')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (2, N'lblapellido', N'Last Name')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (2, N'lbldni', N'ID #')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (2, N'lblidioma', N'Language')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (2, N'lblnombre', N'First Name')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (2, N'lbllocalidad', N'Town')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Leyenda], [Traduccion]) VALUES (2, N'Servicios', N'Services')
/****** Object:  StoredProcedure [dbo].[s_Usuarios_Listar]    Script Date: 04/16/2016 00:19:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[s_Usuarios_Listar]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  
	SELECT
        IdUsuario,
		Nombre,
		Apellido,
		DNI,
		Usuario.IdLocalidad,
		Localidad.Descripcion AS Localidad,
        Activo,
        Usuario.ID_Idioma,
        Idioma.Descripcion
			
	FROM	Usuario, Localidad, Idioma

	WHERE	Activo = 'True' and Localidad.IdLocalidad = Usuario.IdLocalidad and Usuario.ID_Idioma = Idioma.ID_Idioma
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_Modificar]    Script Date: 04/16/2016 00:19:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[s_Usuario_Modificar]

	@IdUsuario int, 
	@Nombre varchar(50),
	@Apellido varchar(50),
	@DNI int,
    @IdLocalidad int,
    @IdIdioma int
    

AS
BEGIN
	
	SET NOCOUNT ON;

   UPDATE Usuario
   SET [Nombre] = @Nombre,
       [Apellido] = @Apellido,
       [DNI] = @DNI,
       [IdLocalidad]= @IdLocalidad,
       [ID_Idioma]= @IdIdioma

        WHERE IdUsuario=@IdUsuario

END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_Listar]    Script Date: 04/16/2016 00:19:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[s_Usuario_Listar]

@IdUsuario int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		SELECT
		IdUsuario,
		Nombre,
		Apellido,
		DNI,
		Usuario.IdLocalidad,
		Localidad.Descripcion AS Localidad,
		Activo,
		Idioma.ID_Idioma,
		Idioma.Descripcion

	FROM	Usuario, Localidad, Idioma

	
	WHERE	Activo = 'True' and Usuario.IdUsuario= @IdUsuario and Idioma.ID_Idioma = Usuario.ID_Idioma and Localidad.IdLocalidad = Usuario.IdLocalidad
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_Crear]    Script Date: 04/16/2016 00:19:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[s_Usuario_Crear]

	@Nombre varchar(50),
    @Apellido varchar(50),
	@DNI int,
	@IdLocalidad int,
	@Activo bit,
	@IDIdioma int
AS
BEGIN

	SET NOCOUNT ON;

INSERT INTO Usuario
	(Nombre,Apellido,DNI,IdLocalidad,Activo,ID_Idioma)
     VALUES
    (@Nombre,@Apellido,@DNI,@IdLocalidad,@Activo, @IDIdioma)
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_Baja]    Script Date: 04/16/2016 00:19:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[s_Usuario_Baja]
	
	 @IdUsuario int,
	 @Activo bit
AS
BEGIN
SET NOCOUNT ON;


	UPDATE	Usuario
	SET		Activo=@Activo
	WHERE	IdUsuario = @IdUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[s_TraduccionesPorIdioma_Listar]    Script Date: 04/16/2016 00:19:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_TraduccionesPorIdioma_Listar]
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
/****** Object:  StoredProcedure [dbo].[s_Traduccion_Listar]    Script Date: 04/16/2016 00:19:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Traduccion_Listar]
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
/****** Object:  ForeignKey [FK_Traduccion_Idioma]    Script Date: 04/16/2016 00:19:23 ******/
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Idioma] FOREIGN KEY([ID_Idioma])
REFERENCES [dbo].[Idioma] ([ID_Idioma])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Idioma]
GO
/****** Object:  ForeignKey [FK_Traduccion_Leyenda]    Script Date: 04/16/2016 00:19:23 ******/
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Leyenda] FOREIGN KEY([ID_Leyenda])
REFERENCES [dbo].[Leyenda] ([ID_Leyenda])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Leyenda]
GO
/****** Object:  ForeignKey [FK_Usuario_Localidad]    Script Date: 04/16/2016 00:19:23 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Localidad] FOREIGN KEY([IdLocalidad])
REFERENCES [dbo].[Localidad] ([IdLocalidad])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Localidad]
GO
