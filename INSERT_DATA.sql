
INSERT INTO CSYT(MACSYT, TENCSYT, DCCSYT, SDTCSYT) VALUES ('CS1','Benh vien da khoa Hong Duc','32/2 Thong Nhat - Phuong 10 - Quan Go Vap - TPHCM ', '0283996999');

EXEC sp_THEMNHANVIEN('NV1',N'Do Khanh Ly', N'Nu', '2001-12-12','371953100', N'Kien Giang', '0868706271', 'CS1', N'Thanh tra', NULL);
EXEC sp_THEMNHANVIEN('NV2',N'Do Tuong Vy', N'Nu', '2000-12-12','371953101', N'Kien Giang', '0777009958', 'CS1', N'Y sy/bac sy', 'CK1');

EXEC sp_THEMBENHNHAN('BN1','CS1', N'Tran Van Anh','916773394', '1954-03-11', 148, N'3 tháng 2', N'Q.1', N'Can Tho', N'NULL', N'NULL', N'NULL');

INSERT INTO HSBA(MAHSBA,MABN,NGAY,CHANDOAN,MABS,MAKHOA,MACSYT,KETLUAN) 
VALUES ('HSBA1', 'BN1', TO_DATE('2020-01-01', 'yyyy-mm-dd'), 'chuan doan 1', 'NV1', 'CK1', 'CS1', 'ket luan 1');

INSERT INTO HSBA_DV(MAHSBA,MADV,NGAY,MAKTV,KETQUA)
VALUES ('HSBA1', 'DV1',TO_DATE('2020-01-01', 'yyyy-mm-dd'), 'NV2', 'ket qua dich vu 1');