--TC#3
--TAO ROLE COSOYTE
CREATE ROLE R_COSOYTE;
GRANT CREATE SESSION TO R_COSOYTE;

--TAO VIEW CAU A
CREATE OR REPLACE VIEW QLYCSYT.V_CSYT_HSBA
AS SELECT * FROM HSBA
WHERE MACSYT = (SELECT CSYT FROM NHANVIEN WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER'))
WITH CHECK OPTION;
/
--TAO TRIGGER THEM HSBA
CREATE OR REPLACE TRIGGER TRG_INSERT_HSBA
INSTEAD OF INSERT ON QLYCSYT.V_CSYT_HSBA
FOR EACH ROW
DECLARE
BEGIN
    INSERT INTO HSBA 
    VALUES (:NEW.MAHSBA, :NEW.MABN, :NEW.NGAY, :NEW.CHANDOAN, :NEW.MABS, :NEW.MAKHOA, :NEW.MACSYT, :NEW.KETLUAN);
END;
/
--TAO TRIGGER XOA HSBA
CREATE OR REPLACE TRIGGER TRG_DELETE_HSBA
INSTEAD OF DELETE ON QLYCSYT.V_CSYT_HSBA
FOR EACH ROW
DECLARE
BEGIN
    DELETE FROM HSBA 
    WHERE MAHSBA = :NEW.MAHSBA;
END;
/
--TAO VIEW CAU B
CREATE OR REPLACE VIEW QLYCSYT.V_HSBA_HSBA_DV
AS SELECT * FROM HSBA_DV
WHERE MAHSBA IN (SELECT MAHSBA FROM HSBA WHERE MACSYT = (SELECT CSYT FROM NHANVIEN WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER')))
WITH CHECK OPTION;
/
--TAO TRIGGER THEM HSBA_DV
CREATE OR REPLACE TRIGGER TRG_INSERT_HSBA_DV
INSTEAD OF INSERT ON QLYCSYT.V_HSBA_HSBA_DV
FOR EACH ROW
DECLARE
BEGIN
    INSERT INTO HSBA_DV 
    VALUES (:NEW.MAHSBA, :NEW.MADV, :NEW.NGAY, :NEW.MAKTV, :NEW.KETQUA);
END;
/
--TAO TRIGGER XOA HSBA_DV
CREATE OR REPLACE TRIGGER TRG_DELETE_HSBA_DV
INSTEAD OF DELETE ON QLYCSYT.V_HSBA_HSBA_DV
FOR EACH ROW
DECLARE
BEGIN
    DELETE FROM HSBA_DV 
    WHERE MAHSBA = :NEW.MAHSBA;
END;
/
--CAP QUYEN CHO ROLE R_COSOYTE
GRANT SELECT, INSERT, DELETE ON V_CSYT_HSBA TO R_COSOYTE;
GRANT SELECT, INSERT, DELETE ON V_HSBA_HSBA_DV TO R_COSOYTE;
