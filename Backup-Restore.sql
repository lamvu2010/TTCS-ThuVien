
--Mở thêm server role cho quản lý thư viện
--sp_addsrvrolemember 'ThuThu', 'dbcreator'
--sp_addsrvrolemember 'ThuThu', 'diskadmin'

-- Mapping thêm cho login quản lý thư viện vào nhóm QuanLy vào database master và grant cho sử dụng sp
-- Mn có thể thực hiện lệnh sau sau khi tạo sp_restore
--USE master GO CREATE USER UsernamTKQL FOR LOGIN LoginnameTKQL GO
--GRANT EXECUTE ON SP_RESTORE TO UsernameTKQL GO
--GRANT EXECUTE ON SP_RESTORE_FULL TO UsernameTKQL GO
--Tạo thư mục d:\THUVIEN\BACKUP\

USE [ThuVien]
GO
CREATE PROC SP_BACKUP
AS
BEGIN
	IF (NOT EXISTS(SELECT* FROM sys.sysdevices WHERE name='backup_ThuVien'))
	BEGIN
		EXEC sp_addumpdevice 'disk', 'backup_ThuVien','d:\THUVIEN\BACKUP\backup_ThuVien.bak'
		BACKUP DATABASE ThuVien TO backup_ThuVien WITH INIT
	END
	IF (NOT EXISTS(SELECT* FROM sys.sysdevices WHERE name='backup_ThuVienLog'))
	BEGIN
		EXEC sp_addumpdevice 'disk', 'backup_ThuVienLog','d:\THUVIEN\BACKUP\backup_ThuVienLog.bak'
		BACKUP LOG ThuVien TO backup_ThuVienLog WITH INIT
	END
	IF (NOT EXISTS(SELECT* FROM sys.sysdevices WHERE name='backup_ThuVienDiff'))
	BEGIN
		EXEC sp_addumpdevice 'disk', 'backup_ThuVienDiff','d:\THUVIEN\BACKUP\backup_ThuVienDiff.bak'
	END
	BACKUP DATABASE ThuVien TO backup_ThuVienDiff WITH DIFFERENTIAL, INIT
END
GO
USE [master]
GO
CREATE PROC SP_RESTORE
AS
BEGIN
	ALTER DATABASE ThuVien SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	BACKUP LOG ThuVien TO backup_ThuVienLog WITH NORECOVERY
	RESTORE DATABASE ThuVien FROM backup_ThuVien WITH NORECOVERY
	RESTORE DATABASE ThuVien FROM backup_ThuVienDiff WITH RECOVERY
	ALTER DATABASE ThuVien SET MULTI_USER
END
GO
CREATE PROC SP_RESTORE_FULL
AS
BEGIN
	ALTER DATABASE ThuVien SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	BACKUP LOG ThuVien TO backup_ThuVienLog WITH NORECOVERY
	RESTORE DATABASE ThuVien FROM backup_ThuVien
	ALTER DATABASE ThuVien SET MULTI_USER
END
GO
USE [msdb]  
GO  
EXEC dbo.sp_add_job  
    @job_name = N'Backup ThuVien' ;  
GO  
EXEC sp_add_jobstep  
    @job_name = N'Backup ThuVien',  
    @step_name = N'Backup ThuVien Weekly',  
    @subsystem = N'TSQL',  
    @command = N'BACKUP DATABASE ThuVien TO backup_ThuVien WITH INIT',   
    @retry_attempts = 5,  
    @retry_interval = 5 ;  
GO  
EXEC dbo.sp_add_schedule  
    @schedule_name = N'Backup ThuVien Weekly',  
    @freq_type =  8,-- chế độ weekly
	@freq_interval =1,--Sunday
	@freq_recurrence_factor=1,
    @active_start_time = 235900;
USE msdb
GO  
EXEC sp_attach_schedule  
   @job_name = N'Backup ThuVien',  
   @schedule_name = N'Backup ThuVien Weekly';  
GO  
EXEC dbo.sp_add_jobserver  
    @job_name = N'Backup ThuVien';  
GO  
CREATE PROC SP_DEL_BACKUP
AS
BEGIN
EXEC sp_dropdevice 'backup_ThuVien', 'delfile'
EXEC sp_dropdevice 'backup_ThuVienDiff', 'delfile'
EXEC sp_dropdevice 'backup_ThuVienLog', 'delfile'
END