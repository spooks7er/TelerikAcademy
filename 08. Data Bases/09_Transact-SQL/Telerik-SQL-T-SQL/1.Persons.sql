USE [Persons]
GO
SET IDENTITY_INSERT [dbo].[Persons] ON 

INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [SSN]) VALUES (2, N'Horas', N'Nightingale', N'9874568475')
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [SSN]) VALUES (3, N'Brigite', N'Florens', N'136489754 ')
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [SSN]) VALUES (4, N'Frida', N'Bornelli', N'6977895482')
SET IDENTITY_INSERT [dbo].[Persons] OFF
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([Id], [PersonnId], [Balance]) VALUES (1, 2, 2598.5900)
INSERT [dbo].[Accounts] ([Id], [PersonnId], [Balance]) VALUES (2, 3, 2546.0000)
INSERT [dbo].[Accounts] ([Id], [PersonnId], [Balance]) VALUES (3, 4, 987.0000)
INSERT [dbo].[Accounts] ([Id], [PersonnId], [Balance]) VALUES (4, 2, 64555.0000)
INSERT [dbo].[Accounts] ([Id], [PersonnId], [Balance]) VALUES (5, 3, 0.0000)
SET IDENTITY_INSERT [dbo].[Accounts] OFF
SET IDENTITY_INSERT [dbo].[Logs] ON 

INSERT [dbo].[Logs] ([Id], [AccountId], [OldSum], [NewSum]) VALUES (1, 2, 546.0000, 2546.0000)
INSERT [dbo].[Logs] ([Id], [AccountId], [OldSum], [NewSum]) VALUES (2, 4, 65555.0000, 64555.0000)
INSERT [dbo].[Logs] ([Id], [AccountId], [OldSum], [NewSum]) VALUES (3, 1, 598.5900, 2598.5900)
SET IDENTITY_INSERT [dbo].[Logs] OFF
