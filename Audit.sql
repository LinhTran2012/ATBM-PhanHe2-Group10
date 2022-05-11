--Mo Run SQL Command Line va ket noi bang tai khoan sys bang cach chay cau lenh :connect sys as sysdba
--Kiem tra AUDIT da duoc kich hoat chua bang cach chay cau lenh:show parameter audit_trail;
--Neu gia tri dong AUDIT_TRAIL la FALSE thi chay cac cau lenh ben duoi:
--alter system set AUDIT_TRAIL=db, extended scope=spfile;
--shutdown immediate;
--startup;


--Ket noi vao tai khoan QLYCSYT va cai dat cac audit:
-- (SA)Chinh sach 1 :Audit lai tat ca cac hanh dong INSERT,DELETE , UPDATE tren bang HSBA
AUDIT INSERT,DELETE,UPDATE ON QLYCSYT.HSBA BY ACCESS;

-- (SA)Chinh sach 2 :Audit lai tat ca cac hanh dong INSERT,DELETE , UPDATE tren bang HSBA_DV
AUDIT INSERT,DELETE,UPDATE ON QLYCSYT.HSBA_DV BY ACCESS;



CREATE TABLE FGA_AUDIT
(
    table_name VARCHAR2(10),
    transaction_name VARCHAR2(10),
    by_user VARCHAR2(30),
    old_value varchar2(32),
    new_value varchar2(32),
    transaction_date DATE
);

-- (FGA)Chinh sach 1: Audit lai cac truong hop update CMND trên bang NHANVIEN duoc thuc hien boi nguoi khac:
CREATE OR REPLACE TRIGGER trg_audit_NHANVIEN
AFTER  UPDATE OF CMND ON NHANVIEN
FOR EACH ROW
BEGIN
    if(:OLD.MANV != SYS_CONTEXT('userenv', 'session_user')) THEN
        -- insert a row into the audit table
        INSERT INTO FGA_AUDIT VALUES('NHANVIEN', 'UPDATE', USER,decrypt(:OLD.CMND),decrypt(:NEW.CMND), SYSDATE);
    END IF;
END;

-- (FGA)Chinh sach 2: Audit lai cac truong hop update CMND trên bang BENHNHAN duoc thuc hien boi nguoi khac:
CREATE OR REPLACE TRIGGER trg_audit_BENHNHAN
AFTER  UPDATE OF CMND ON BENHNHAN
FOR EACH ROW
BEGIN

    if(:OLD.MABN != SYS_CONTEXT('userenv', 'session_user')) THEN
        -- insert a row into the audit table
        INSERT INTO FGA_AUDIT VALUES('BENHNHAN', 'UPDATE', USER,decrypt(:OLD.CMND),decrypt(:NEW.CMND), SYSDATE);
    END IF;
END;

--select * from  FGA_AUDIT
--update NHANVIEN
--SET CMND = encrypt('123456789')
--where MANV ='NV7';
