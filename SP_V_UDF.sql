USE [QLDSV_TC]
GO
/****** Object:  UserDefinedFunction [dbo].[CHECK_GIOI_TINH]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[CHECK_GIOI_TINH]
( @PHAI_ID INT )

RETURNS nvarchar(5)

AS

BEGIN

DECLARE @PHAI_NAME NVARCHAR(5);

IF @PHAI_ID = 1
SET @PHAI_NAME= N'Nữ';
ELSE IF @PHAI_ID= 0
SET @PHAI_NAME = 'Nam';

RETURN @PHAI_NAME;

END;
GO
/****** Object:  UserDefinedFunction [dbo].[NumtoText]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[NumtoText](@Number int)
RETURNS nvarchar(4000) AS
BEGIN
DECLARE @sNumber nvarchar(4000)
DECLARE @Return nvarchar(4000)
DECLARE @mLen int
DECLARE @i int
DECLARE @mDigit int
DECLARE @mGroup int
DECLARE @mTemp nvarchar(4000)
DECLARE @mNumText nvarchar(4000)
SELECT @sNumber=LTRIM(STR(@Number))
SELECT @mLen = Len(@sNumber)
SELECT @i=1
SELECT @mTemp=''
WHILE @i <= @mLen
BEGIN
SELECT @mDigit=SUBSTRING(@sNumber, @i, 1)
IF @mDigit=0 SELECT @mNumText=N'không'
ELSE
BEGIN
    IF @mDigit=1 SELECT @mNumText=N'một'
    ELSE
    IF @mDigit=2 SELECT @mNumText=N'hai'
    ELSE
    IF @mDigit=3 SELECT @mNumText=N'ba'
    ELSE
    IF @mDigit=4 SELECT @mNumText=N'bốn'
    ELSE
    IF @mDigit=5 SELECT @mNumText=N'năm'
    ELSE
    IF @mDigit=6 SELECT @mNumText=N'sáu'
    ELSE
    IF @mDigit=7 SELECT @mNumText=N'bảy'
    ELSE
    IF @mDigit=8 SELECT @mNumText=N'tám'
    ELSE
    IF @mDigit=9 SELECT @mNumText=N'chín'
END
SELECT @mTemp = @mTemp + ' ' + @mNumText
IF (@mLen = @i) BREAK
Select @mGroup=(@mLen - @i) % 9
IF @mGroup=0
BEGIN
    SELECT @mTemp = @mTemp + N' tỷ'
    If SUBSTRING(@sNumber, @i + 1, 3) = N'000'
    SELECT @i = @i + 3
    If SUBSTRING(@sNumber, @i + 1, 3) = N'000'
    SELECT @i = @i + 3
    If SUBSTRING(@sNumber, @i + 1, 3) = N'000'
    SELECT @i = @i + 3
END
ELSE
IF @mGroup=6
BEGIN
    SELECT @mTemp = @mTemp + N' triệu'
    If SUBSTRING(@sNumber, @i + 1, 3) = N'000'
    SELECT @i = @i + 3
    If SUBSTRING(@sNumber, @i + 1, 3) = N'000'
    SELECT @i = @i + 3
END
ELSE
IF @mGroup=3
BEGIN
    SELECT @mTemp = @mTemp + N' nghìn'
    If SUBSTRING(@sNumber, @i + 1, 3) = N'000'
    SELECT @i = @i + 3
END
ELSE
BEGIN
    Select @mGroup=(@mLen - @i) % 3
    IF @mGroup=2   
    SELECT @mTemp = @mTemp + N' trăm'
    ELSE
    IF @mGroup=1
    SELECT @mTemp = @mTemp + N' mươi'  
END
SELECT @i=@i+1
END
--'Loại bỏ trường hợp x00
SELECT @mTemp = Replace(@mTemp, N'không mươi không', '')
--'Loại bỏ trường hợp 00x
SELECT @mTemp = Replace(@mTemp, N'không mươi ', N'linh ')
--'Loại bỏ trường hợp x0, x>=2
SELECT @mTemp = Replace(@mTemp, N'mươi không', N'mươi')
--'Fix trường hợp 10
SELECT @mTemp = Replace(@mTemp, N'một mươi', N'mười')
--'Fix trường hợp x4, x>=2
SELECT @mTemp = Replace(@mTemp, N'mươi bốn', N'mươi tư')
--'Fix trường hợp x04
SELECT @mTemp = Replace(@mTemp, N'linh bốn', N'linh tư')
--'Fix trường hợp x5, x>=2
SELECT @mTemp = Replace(@mTemp, N'mươi năm', N'mươi lăm')
--'Fix trường hợp x1, x>=2
SELECT @mTemp = Replace(@mTemp, N'mươi một', N'mươi mốt')
--'Fix trường hợp x15
SELECT @mTemp = Replace(@mTemp, N'mười năm', N'mười lăm')
--'Bỏ ký tự space
SELECT @mTemp = LTrim(@mTemp)
--'Ucase ký tự đầu tiên
SELECT @Return=UPPER(Left(@mTemp, 1)) + SUBSTRING(@mTemp,2, 4000)
RETURN @Return 
END
GO
/****** Object:  View [dbo].[Get_Loginnames]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Get_Loginnames]
AS
SELECT sp.name
FROM     sys.server_principals AS sp INNER JOIN
                  sys.database_principals AS dp ON sp.sid = dp.sid
GO
/****** Object:  View [dbo].[Get_Subscribes]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Get_Subscribes] 
AS
SELECT PUBS.description AS TENCN, SUBS.subscriber_server AS TENSERVER
FROM     dbo.sysmergepublications AS PUBS INNER JOIN
                  dbo.sysmergesubscriptions AS SUBS ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server
GO
/****** Object:  View [dbo].[Get_Subscribes1]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--KHÔNG LẤY TÊN PHÂN MẢNH 3 (CHUYỂN SITE CMB)
CREATE VIEW [dbo].[Get_Subscribes1]	
AS	
SELECT PUBS.description AS TENCN, SUBS.subscriber_server AS TENSERVER
FROM     dbo.sysmergepublications AS PUBS INNER JOIN
                  dbo.sysmergesubscriptions AS SUBS ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server AND PUBS.publication_type <> 0


GO
/****** Object:  View [dbo].[Get_Usernames]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Get_Usernames]
AS
SELECT u.name
FROM     sys.database_permissions AS sp INNER JOIN
                  sys.database_principals AS u LEFT OUTER JOIN
                  sys.server_principals AS dp ON u.sid = dp.sid ON sp.grantee_principal_id = u.principal_id
WHERE  (sp.type = 'CO')
GO
/****** Object:  StoredProcedure [dbo].[CHECK_EXISTS_SV_PASS]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[CHECK_EXISTS_SV_PASS] @MASV nchar(10), @PASSWORD nvarchar(40)
AS
SELECT * FROM SINHVIEN WHERE MASV = @MASV AND PASSWORD = @PASSWORD
GO
/****** Object:  StoredProcedure [dbo].[DS_LOP_LTC_SV]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DS_LOP_LTC_SV] @MASV nchar(10)
AS
SELECT LTC.MALTC, LTC.NIENKHOA, LTC.HOCKY, MONHOC.TENMH, TENGV, LTC.NHOM FROM
	 (SELECT MAGV,TENGV=HO+' '+TEN FROM GIANGVIEN ) GV,
	 (SELECT MALTC, MASV FROM DANGKY WHERE MASV =@MASV AND HUYDANGKY = 'False') DK,
     (SELECT MALTC,NIENKHOA,HOCKY,MAGV,NHOM,MAMH FROM LOPTINCHI) LTC,MONHOC
WHERE GV.MAGV = LTC.MAGV AND MONHOC.MAMH = LTC.MAMH AND DK.MALTC = LTC.MALTC 
GO
/****** Object:  StoredProcedure [dbo].[DS_LTC]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROC [dbo].[DS_LTC] @NIENKHOA nchar(9), @HOCKY int
 AS
SELECT LOPTINCHI.MALTC,MAMH,
 TENMONHOC=(SELECT TENMH FROM MONHOC WHERE MONHOC.MAMH=LOPTINCHI.MAMH),
 NHOM,
 TENGV=(SELECT HO+' '+TEN FROM GIANGVIEN WHERE GIANGVIEN.MAGV=LOPTINCHI.MAGV),
SOSVDK=(SELECT count(*) FROM DANGKY WHERE HUYDANGKY ='False' AND  DANGKY.MALTC = LOPTINCHI.MALTC) 
FROM LOPTINCHI LEFT JOIN DANGKY ON DANGKY.MALTC = LOPTINCHI.MALTC 
 WHERE LOPTINCHI.NIENKHOA = @NIENKHOA AND LOPTINCHI.HOCKY = @HOCKY
 GROUP BY LOPTINCHI.MALTC,MAMH,MAGV,NHOM,SOSVTOITHIEU
GO
/****** Object:  StoredProcedure [dbo].[GetAllNienKhoa]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllNienKhoa] as 
select NIENKHOA from LOPTINCHI group by NIENKHOA
GO
/****** Object:  StoredProcedure [dbo].[KT_MALOP_TRUNG]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[KT_MALOP_TRUNG] @MALOP nchar(10)
AS 
SELECT * FROM LINK0.QLDSV_TC.DBO.LOP WHERE MALOP = @MALOP
GO
/****** Object:  StoredProcedure [dbo].[KT_MAMON_TRUNG]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[KT_MAMON_TRUNG] @MAMH nchar(10)
AS
SELECT * FROM MONHOC WHERE  MAMH =@MAMH
GO
/****** Object:  StoredProcedure [dbo].[KT_MASV_TRUNG]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[KT_MASV_TRUNG] @MASV nchar(10)
AS 
SELECT * FROM LINK0.QLDSV_TC.DBO.SINHVIEN WHERE MASV = @MASV
GO
/****** Object:  StoredProcedure [dbo].[SP_BDMH]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BDMH] @NienKhoa varchar(9), @HocKy int, @Nhom int,@MonHoc nvarchar(50)
as
declare @LOPTINCHI int
select @LOPTINCHI= MALTC from LOPTINCHI,MONHOC
where LOPTINCHI.NIENKHOA = @NienKhoa AND LOPTINCHI.HOCKY = @HocKy AND LOPTINCHI.NHOM = @Nhom
AND MONHOC.MAMH = @MonHoc AND LOPTINCHI.MAMH = MONHOC.MAMH
select MALC=@LOPTINCHI,SINHVIEN.MASV,HOTEN=HO+' '+TEN,DIEM_CC,DIEM_GK,DIEM_CK,DIEM_TK= DIEM_CC*0.1 + DIEM_GK*0.3 + DIEM_CK*0.6 from DANGKY,SINHVIEN
where  DANGKY.MASV = SINHVIEN.MASV AND DANGKY.MALTC = @LOPTINCHI AND HUYDANGKY = 0
order by TEN,HO
GO
/****** Object:  StoredProcedure [dbo].[SP_Chuyen_Lop_SV]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Chuyen_Lop_SV]
    @MASV nchar(10), @MALOP nchar(10) 
AS
BEGIN 
    UPDATE SINHVIEN
    SET MALOP = @MALOP
    WHERE MASV = @MASV 
    IF NOT EXISTS (SELECT * FROM SINHVIEN WHERE MASV = @MASV AND MALOP = @MALOP)
	RAISERROR('Chuyển sinh viên thất bại!',16,1)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetCTHP_SV]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GetCTHP_SV]
@MASV VARCHAR(10), @NIENKHOA NCHAR(9), @HOCKY INT
AS SELECT NGAYDONG, SOTIENDONG FROM dbo.CT_DONGHOCPHI WHERE NIENKHOA = @NIENKHOA AND HOCKY = @HOCKY AND MASV = @MASV
GO
/****** Object:  StoredProcedure [dbo].[SP_GetDSHP_SV]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROC [dbo].[SP_GetDSHP_SV]
@MASV VARCHAR(10)
AS
BEGIN
	with GETINFOHP(MASV,NIENKHOA,HOCKY,TONGSOTIENDADONG)
as (select HOCPHI.MASV,HOCPHI.NIENKHOA,HOCPHI.HOCKY,SUM(SOTIENDONG) from HOCPHI,CT_DONGHOCPHI 
where HOCPHI.MASV = CT_DONGHOCPHI.MASV AND HOCPHI.NIENKHOA = CT_DONGHOCPHI.NIENKHOA AND HOCPHI.HOCKY = CT_DONGHOCPHI.HOCKY
group by HOCPHI.MASV,HOCPHI.NIENKHOA,HOCPHI.HOCKY)
select HOCPHI.MASV, HOCPHI.NIENKHOA,HOCPHI.HOCKY,HOCPHI,TONGSOTIENDADONG=COALESCE(TONGSOTIENDADONG,0), SOTIENCANDONG= COALESCE(HOCPHI-TONGSOTIENDADONG,HOCPHI) 
from HOCPHI left join GETINFOHP
on HOCPHI.MASV = GETINFOHP.MASV AND HOCPHI.NIENKHOA = GETINFOHP.NIENKHOA AND HOCPHI.HOCKY = GETINFOHP.HOCKY
where HOCPHI.MASV = @MASV
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetInfoSV_HP]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GetInfoSV_HP]
@masv VARCHAR(10)
AS SELECT HOTEN=HO + TEN, MALOP FROM dbo.SINHVIEN WHERE MASV = @masv
GO
/****** Object:  StoredProcedure [dbo].[SP_IN_BANGDIEMTONGKET]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_IN_BANGDIEMTONGKET] @MALOP NVARCHAR(15)
AS
BEGIN
	SELECT SV.MASV, HOTEN, TENMH, DIEM=(DIEM_CC*0.1+DIEM_GK*0.3+ DIEM_CK*0.6)
	FROM (SELECT MASV, MALTC, DIEM_CC,DIEM_GK, DIEM_CK FROM DANGKY WHERE HUYDANGKY='False') DK,
		 (SELECT MASV, HOTEN=HO+' '+TEN FROM SINHVIEN WHERE MALOP = @MALOP AND DANGHIHOC = 'False') SV,
		 (SELECT MALTC, MAMH FROM LOPTINCHI) LTC, MONHOC
		 WHERE DK.MASV = SV.MASV AND DK.MALTC = LTC.MALTC AND LTC.MAMH = MONHOC.MAMH
END 
GO
/****** Object:  StoredProcedure [dbo].[SP_In_BDMH]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_In_BDMH] @NIENKHOA nchar(9), @HOCKY int, @MAMH nchar(10), @NHOM INT
AS
BEGIN
	SELECT SV.MASV, SV.HO,SV.TEN, DK.DIEM_CC,DK.DIEM_GK,DK.DIEM_CK 
		FROM(SELECT MASV, MALTC, DIEM_CC,DIEM_GK, DIEM_CK FROM DANGKY WHERE HUYDANGKY='False') DK,
			(SELECT MASV, HO,TEN FROM SINHVIEN WHERE DANGHIHOC = 'False' ) SV,
			(SELECT MALTC FROM LOPTINCHI WHERE NIENKHOA =@NIENKHOA AND HOCKY = @HOCKY AND MAMH = @MAMH AND NHOM =@NHOM) LTC
			WHERE LTC.MALTC = DK.MALTC AND SV.MASV = DK.MASV
			ORDER BY SV.TEN, SV.HO
END
GO
/****** Object:  StoredProcedure [dbo].[SP_In_DiemSv]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_In_DiemSv] @MASV nchar(10)
as
BEGIN
	SELECT TENMH, MAX(Diem) AS 'ĐIỂM'
	FROM(SELECT Diem=DIEM_CC*0.1+ DIEM_GK*0.3+ 0.6*DIEM_CK, MALTC FROM DANGKY WHERE MASV = @MASV AND HUYDANGKY='False') DK,
		(SELECT MALTC, MAMH FROM LOPTINCHI) LTC,MONHOC
		WHERE LTC.MALTC = DK.MALTC AND MONHOC.MAMH = LTC.MAMH
		GROUP BY TENMH
		ORDER BY TENMH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_IN_DSLTC]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_IN_DSLTC] @NIENKHOA nchar(9), @HOCKY int
AS
BEGIN
	SELECT TENMH, LTC.NHOM, GV.HO + ' '+GV.TEN AS 'Tên GV', LTC.SOSVTOITHIEU , COUNT(DK.MASV) AS 'Số SV đã đăng ký' 
	FROM(SELECT MASV, MALTC FROM DANGKY WHERE HUYDANGKY='False') DK,
		(SELECT MAGV, HO, TEN FROM GIANGVIEN) GV,
		(SELECT MALTC, MAMH, SOSVTOITHIEU, NHOM, MAGV FROM LOPTINCHI WHERE NIENKHOA = @NIENKHOA AND HOCKY = @HOCKY) LTC, MONHOC
		WHERE LTC.MALTC = DK.MALTC AND MONHOC.MAMH = LTC.MAMH AND LTC.MAGV = GV.MAGV
		GROUP BY HO, TEN, TENMH, NHOM, SOSVTOITHIEU
		ORDER BY TENMH, NHOM
END
GO
/****** Object:  StoredProcedure [dbo].[SP_In_HocPhi]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_In_HocPhi] @MALOP nchar(10), @NIENKHOA nchar(9), @HOCKY int
AS
BEGIN
	SELECT SV.HO + ' ' + SV.TEN AS 'Họ tên SV', HP.HOCPHI, SUM(CT_HP.SOTIENDONG) AS 'SOTIENDONG'
		FROM(SELECT MASV, HO, TEN FROM SINHVIEN WHERE MALOP = @MALOP) SV,
			(SELECT HOCPHI, MASV FROM HOCPHI WHERE NIENKHOA = @NIENKHOA AND HOCKY = @HOCKY) HP,
			(SELECT MASV, SOTIENDONG FROM CT_DONGHOCPHI) CT_HP
			WHERE SV.MASV = HP.MASV AND SV.MASV  =CT_HP.MASV
			GROUP BY TEN, HO, HOCPHI
END
GO
/****** Object:  StoredProcedure [dbo].[SP_In_SVDKLTC]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_In_SVDKLTC] @NIENKHOA nchar(9), @HOCKY int, @MAMH nchar(10), @NHOM INT
AS
BEGIN
	SELECT SV.MASV, SV.HO, SV.TEN, dbo.CHECK_GIOI_TINH(SV.PHAI) AS PHAI, MALOP
	FROM(SELECT MASV, HO, TEN, PHAI, MALOP FROM SINHVIEN WHERE DANGHIHOC = 'False') SV,
		(SELECT  MALTC FROM LOPTINCHI WHERE NIENKHOA = @NIENKHOA AND HOCKY = @HOCKY AND MAMH = @MAMH AND NHOM = @NHOM) LTC,
		(SELECT MALTC, MASV FROM DANGKY WHERE HUYDANGKY = 'False') DK
		WHERE SV.MASV = DK.MASV AND LTC.MALTC = DK.MALTC
		ORDER BY TEN, HO
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Kt_Loginname]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Kt_Loginname] @lName nchar(30)
AS
SELECT * from Get_Loginnames WHERE name = @lName
GO
/****** Object:  StoredProcedure [dbo].[SP_Kt_Username]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Kt_Username] @uName nchar(20)
AS
SELECT * from Get_Usernames WHERE name = @uName
GO
/****** Object:  StoredProcedure [dbo].[SP_LayDSGV]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LayDSGV] AS
BEGIN
	SELECT MAGV,HOTEN = HO+' '+TEN FROM dbo.GIANGVIEN 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOLOGIN]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAOLOGIN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50),
  @ROLE VARCHAR(50)
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLDSV_TC'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE= 'PGV' OR @ROLE= 'PKT' OR @ROLE= 'KHOA'
  BEGIN 
    EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
    EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
  END
RETURN 0  
GO
/****** Object:  StoredProcedure [dbo].[SP_ThongTinGV]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ThongTinGV] @TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50), @TENNHOM nvarchar(50),
@USERNAME NVARCHAR(10), @HOTEN NVARCHAR(50)
SELECT @USERNAME = NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
SELECT @TENNHOM =  NAME FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID FROM SYS.SYSMEMBERS 
										WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
										WHERE NAME=@USERNAME)) 
IF  EXISTS (SELECT MAGV FROM GIANGVIEN WHERE MAGV = @USERNAME) 
BEGIN 
	SELECT @HOTEN = HO+ ' '+ TEN FROM GIANGVIEN WHERE MAGV = @USERNAME  
	SELECT USERNAME=@USERNAME,HOTEN=@HOTEN,TENNHOM=@TENNHOM
	END
ELSE
IF  EXISTS (SELECT MAGV FROM LINK0.QLDSV_TC.DBO.GIANGVIEN WHERE MAGV = @USERNAME) 
BEGIN 
	SELECT @HOTEN = HO+ ' '+ TEN FROM LINK0.QLDSV_TC.DBO.GIANGVIEN WHERE MAGV = @USERNAME   
SELECT USERNAME=@USERNAME,HOTEN=@HOTEN,TENNHOM=@TENNHOM
END
ELSE RAISERROR (N'Mã GV không có trong danh sách',16,1)
GO
/****** Object:  StoredProcedure [dbo].[SP_ThongTinSV]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ThongTinSV] @MASV NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50), @TENNHOM nvarchar(50), @HOTEN NVARCHAR(50)

If exists(SELECT MASV FROM  dbo.SINHVIEN WHERE MASV = @MASV)
BEGIN
	SELECT @HOTEN = (SELECT HO+ ' '+ TEN FROM SINHVIEN  WHERE MASV = @MASV )
	SELECT USERNAME=@MASV,HOTEN=@HOTEN,TENNHOM=N'Sinh Viên'
END
ELSE
RAISERROR (N'Mã SV không tồn tại', 16,1)	
GO
/****** Object:  StoredProcedure [dbo].[SP_TongTienHocPhiChu]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TongTienHocPhiChu] @MALOP nchar(10), @NIENKHOA nchar(9), @HOCKY int
AS
SELECT [dbo].[NumtoText](SUM(CT_DONGHOCPHI.SOTIENDONG)) FROM CT_DONGHOCPHI
INNER JOIN SINHVIEN ON (SINHVIEN.MASV = CT_DONGHOCPHI.MASV)
INNER JOIN HOCPHI ON ( CT_DONGHOCPHI.MASV = HOCPHI.MASV)
WHERE  SINHVIEN.MALOP = @MALOP  AND HOCPHI.NIENKHOA = @NIENKHOA AND HOCPHI.HOCKY = @HOCKY
GO
/****** Object:  StoredProcedure [dbo].[SP_XULY_DIEM]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XULY_DIEM]
@MSSV varchar(20),
@MALTC int,
@DIEMCC float,
@DIEMGK float,
@DIEMCK float
as 
BEGIN
	IF EXISTS (Select 1 From DANGKY where MASV = @MSSV AND MALTC = @MALTC)
	BEGIN
		UPDATE DANGKY
		SET DIEM_CC = @DIEMCC, DIEM_GK = @DIEMGK, DIEM_CK = @DIEMCK
		WHERE MASV = @MSSV AND MALTC = @MALTC
	END
	ELSE 
	RAISERROR(N'THÔNG TIN ĐĂNG KÝ KHÔNG TỒN TẠI',16,1)
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_XULY_LTC]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_XULY_LTC] @MASV NVARCHAR(10),  
@MALTC INT,  
@type smallint
--type=1 : đăng ký
--type=2 : hủy
-- SP này để vừa cho sinh viên đăng ký hoặc hủy môn đăng ký
AS  
BEGIN  
	IF (@type=1)
	BEGIN
            IF EXISTS (SELECT 1 FROM DANGKY WHERE MASV=@MASV AND MALTC=@MALTC AND HUYDANGKY = 'False')  
				BEGIN
                    raiserror(N'SINH VIÊN ĐÃ ĐĂNG KÝ LỚP',16,1)
					RETURN
                END  
            ELSE IF EXISTS (SELECT 1 FROM DANGKY WHERE MASV=@MASV AND MALTC=@MALTC AND HUYDANGKY = 'True')  
                BEGIN  
                    UPDATE DANGKY 
                    SET HUYDANGKY='False' WHERE MALTC = @MALTC AND MASV = @MASV
                END
			ELSE
				BEGIN
					INSERT INTO DANGKY(MALTC, MASV, HUYDANGKY) 
                    VALUES (@MALTC, @MASV,'False') 
				END
	END
	ELSE IF(@type = 2)
	BEGIN
		IF EXISTS (SELECT 1 FROM DANGKY WHERE MASV=@MASV AND MALTC=@MALTC)  
				BEGIN
                    UPDATE DANGKY 
					SET HUYDANGKY='True' WHERE MALTC = @MALTC AND MASV = @MASV
                END
		ELSE
			BEGIN
				raiserror(N'SINH VIÊN CHƯA ĐĂNG KÝ LỚP',16,1)				
			END
	END
END
GO

/****** Object:  StoredProcedure [dbo].[SV_DONGTIEN]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SV_DONGTIEN] @MASV varchar(20),@NienKhoa varchar (20), @HocKy int, @SoTienDong int,@Ngay varchar (100)
as

if exists (select 1 from HOCPHI where MASV = @MASV AND NIENKHOA = @NienKhoa AND HOCKY = @HocKy)
	begin
		insert into CT_DONGHOCPHI(MASV,NIENKHOA,HOCKY,SOTIENDONG,NGAYDONG)
		values (@MASV,@NienKhoa,@HocKy,@SoTienDong,@Ngay)
	end
else
	raiserror(N'Thông tin bạn nhập không tồn tại',16,1)
GO
/****** Object:  StoredProcedure [dbo].[TAO_THONGTINHOCPHI]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TAO_THONGTINHOCPHI] @MASV varchar(20),@NienKhoa varchar (20), @HocKy int, @HocPhi int
as
if exists (select 1 from HOCPHI where MASV = @MASV AND NIENKHOA = @NienKhoa AND HOCKY = @HocKy)
	begin
		raiserror(N'ĐÃ TỒN TẠI THÔNG TIN HỌC PHÍ',16,1)
	end
else
	begin
		insert into HOCPHI(MASV,NIENKHOA,HOCKY,HOCPHI)
		values (@MASV,@NienKhoa,@HocKy,@HocPhi)
		
	end
GO
/****** Object:  StoredProcedure [dbo].[thongtin_sv_DKY]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[thongtin_sv_DKY] @MASV nchar(10)
as
IF EXISTS (select MASV from SINHVIEN)
select MASV,HO,TEN,MALOP from SINHVIEN WHERE MASV =@MASV
else 
RAISERROR(N'SINH VIEN KHÔNG TỒN TẠI',16,1)
GO
/****** Object:  StoredProcedure [dbo].[Xoa_Login]    Script Date: 6/13/2022 3:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Xoa_Login]
  @LGNAME VARCHAR(50),
  @USRNAME VARCHAR(50)
  
AS
  EXEC SP_DROPUSER @USRNAME
  EXEC SP_DROPLOGIN @LGNAME
GO
