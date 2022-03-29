CREATE DATABASE HoaHong
USE HoaHong
CREATE TABLE LopHoc(
	MaLop VARCHAR(10) primary key,
	TenLop VARCHAR(20)
	)

DROP TABLE LopHoc

SELECT * FROM LopHoc

INSERT INTO LopHoc(MaLop, TenLop) VALUES
('001','sieu nhan'),
('002','anh hung'),
('003','quai vat');

CREATE TABLE BeNgoan(
	MaBN VARCHAR(10) primary key,
	MaLop VARCHAR(10),
	TenBeNgoan VARCHAR(20),
	NgaySinh DATE,
	GioiTinh VARCHAR(10),
	HoTenBo VARCHAR(20),
	HoTenMe VARCHAR(20),
	DiaChi VARCHAR(20)
	CONSTRAINT fk_malop FOREIGN KEY (MaLop) REFERENCES LopHoc (MaLop) ON DELETE CASCADE,
)

DROP TABLE BeNgoan

SELECT * FROM BeNgoan

INSERT INTO BeNgoan(MaBN, MaLop, TenBeNgoan, NgaySinh, GioiTinh, HoTenBo, HoTenMe, DiaChi) VALUES
('1','001','tri dat','2002-10-1','nam','bo','me','Hai Phong'),
('2','002','tuan ngao','2002-10-2','khong ro','bo1','me1','nha tu'),
('3','003','dat ngoan','2002-10-3','nam','bo2','me2','Hai Phong');

