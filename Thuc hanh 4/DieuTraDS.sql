CREATE DATABASE DieuTraDS
USE DieuTraDS
CREATE TABLE CongDan (
    MaCD VARCHAR(10) primary key,
	MaPhuong VARCHAR(10),
	TenCD VARCHAR(20),
    CMND VARCHAR(20),
	GioiTinh VARCHAR(10),
	NamSinh INT,
	SoDienThoai VARCHAR(20)
	)

DROP TABLE CongDan

SELECT * FROM CongDan

INSERT INTO CongDan (MaCD, MaPhuong, TenCD, CMND, GioiTinh, NamSinh, SoDienThoai) VALUES 
	('1','10', 'dat', '0123456789','nam','2002','0972392585'),
	('2','10', 'phong', '9876543210','nam','2002','5852932720');
