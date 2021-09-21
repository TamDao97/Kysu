CREATE PROC sp_create_touristplace
@ParentId int = null,
@Name nvarchar(500),
@IsSuccess bit = 0 output
AS
	IF EXISTS (SELECT Id FROM TouristPlace WHERE [Name] = @Name) BEGIN
		SELECT @IsSuccess; PRINT N'Tên ??a ?i?m ?ã t?n t?i trên h? th?ng.'
	END
	ELSE BEGIN
		BEGIN TRANSACTION
			BEGIN TRY
				INSERT INTO TouristPlace
				VALUES(@ParentId,@Name)
				COMMIT
					SET	@IsSuccess = 1;
					SELECT @IsSuccess;PRINT N'SUCCESS.'
			END TRY
			BEGIN CATCH
					SET	@IsSuccess = 0; 
					SELECT @IsSuccess
					PRINT ERROR_MESSAGE()
					ROLLBACK
			END CATCH
	END
GO

