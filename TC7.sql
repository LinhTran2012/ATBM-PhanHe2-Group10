--chay voi sys
GRANT ALL PRIVILEGES ON NHANVIEN TO LBACSYS;
--tao bang THONGBAO
CREATE TABLE THONGBAO(
    NOIDUNG NVARCHAR2(1000),
    NGAYGIO DATE,
    DIADIEM NVARCHAR2(100)
);
--giam doc so
CREATE USER GDS IDENTIFIED BY "123";
GRANT CONNECT TO GDS;
GRANT SELECT ON NHANVIEN TO GDS;
--giam doc co so y te
CREATE USER GDCSYT IDENTIFIED BY "123";
GRANT CONNECT TO GDCSYT;
GRANT SELECT ON NHANVIEN TO GDCSYT;

CREATE USER GDCSYT2 IDENTIFIED BY "123";
GRANT CONNECT TO GDCSYT2;
GRANT SELECT ON NHANVIEN TO GDCSYT2;

CREATE USER GDCSYT3 IDENTIFIED BY "123";
GRANT CONNECT TO GDCSYT3;
GRANT SELECT ON NHANVIEN TO GDCSYT3;
--y bac si
CREATE USER YBS IDENTIFIED BY "123";
GRANT CONNECT TO YBS;
GRANT SELECT ON NHANVIEN TO YBS;

ALTER USER lbacsys IDENTIFIED BY lbacsys ACCOUNT UNLOCK;

EXEC LBACSYS.CONFIGURE_OLS;
EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS;

--quyen tao cac thanh phan cua table
GRANT EXECUTE ON sa_components TO QLYCSYT WITH GRANT OPTION;
--quyen gan label cho tai khoan
GRANT EXECUTE ON sa_user_admin TO QLYCSYT WITH GRANT OPTION;
--quyen tao các label
GRANT EXECUTE ON sa_label_admin TO QLYCSYT WITH GRANT OPTION;
--quyen gán policy cho các bang
GRANT EXECUTE ON sa_policy_admin TO QLYCSYT WITH GRANT OPTION;
--chuyen chuoi thành so cua label
GRANT EXECUTE ON CHAR_TO_LABEL TO QLYCSYT WITH GRANT OPTION;

GRANT LBAC_DBA TO QLYCSYT;
--gán quyen thuc thi các hàm cua sa_sysdbs (tao policy)
GRANT EXECUTE ON sa_sysdba TO QLYCSYT;
GRANT EXECUTE ON to_lbac_data_label TO QLYCSYT;

GRANT INHERIT PRIVILEGES ON USER SYS TO LBACSYS;

BEGIN
  SA_SYSDBA.CREATE_POLICY (
    policy_name => 'ThongBao_policy',
    column_name => 'ThongBao_label'
  );
END;

--GRANT ROLE
GRANT ThongBao_policy_DBA TO QLYCSYT;

--muc do vua cho giam doc csyt, thap cho y ba si, cao cho giam doc so
EXECUTE SA_COMPONENTS.CREATE_LEVEL('ThongBao_policy',60,'C','Cao');  
EXECUTE SA_COMPONENTS.CREATE_LEVEL('ThongBao_policy',40,'V','V?a');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('ThongBao_policy',20,'T','Th?p');

EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('ThongBao_policy',100,'DT01','Dieu tri ngoai tru');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('ThongBao_policy',120,'DT02','Dieu tri noi tru');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('ThongBao_policy',130,'DT03','Dieu tri chuyen sau');

EXECUTE SA_COMPONENTS.CREATE_GROUP('ThongBao_policy',1,'V01','Trung tam');
EXECUTE SA_COMPONENTS.CREATE_GROUP('ThongBao_policy',2,'V02','Can trung tam');
EXECUTE SA_COMPONENTS.CREATE_GROUP('ThongBao_policy',3,'V03','Ngoai thanh');

EXECUTE SA_USER_ADMIN.SET_USER_PRIVS('ThongBao_policy','QLYCSYT','FULL,PROFILE_ACCESS');

BEGIN
--Giam doc so
    SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_POLICY', label_tag => 1, label_value => 'C');
    
    --Giam doc csyt
    SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 200, label_value => 'V:DT01:V02');
    SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 210, label_value => 'V:DT02:V03');
    SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 220, label_value => 'V:DT03:V01');
    
    --Y bac si
    SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 100, label_value => 'T:DT02:V01');
END;

show errors

--Ap dung policy vao bang
BEGIN
  SA_POLICY_ADMIN.APPLY_TABLE_POLICY(
    policy_name   => 'ThongBao_policy',
    schema_name   => 'QLYCSYT',
    table_name    => 'THONGBAO',
    table_options => 'NO_CONTROL');
END;

--ap dung 1 lan nua
BEGIN
  SA_POLICY_ADMIN.REMOVE_TABLE_POLICY('ThongBao_policy','QLYCSYT','THONGBAO');
  SA_POLICY_ADMIN.APPLY_TABLE_POLICY (
    policy_name => 'ThongBao_policy',
    schema_name => 'QLYCSYT',
    table_name  => 'THONGBAO',
    table_options => 'READ_CONTROL,WRITE_CONTROL');
END;

show errors;

--gan nhan
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'GDS', 'C:DT03:V01'); 
    SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'GDCSYT', 'V:DT01:V02'); 
    SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'GDCSYT2', 'V:DT02:V03'); 
    SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'GDCSYT3', 'V:DT03:V01');
    SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'YBS', 'T:DT02:V01');
END;

GRANT SELECT, INSERT, UPDATE ON THONGBAO TO GDS;
GRANT SELECT, INSERT, UPDATE ON THONGBAO TO GDCSYT1;
GRANT SELECT, INSERT, UPDATE ON THONGBAO TO GDCSYT2;
GRANT SELECT, INSERT, UPDATE ON THONGBAO TO GDCSYT3;
GRANT SELECT, INSERT, UPDATE ON THONGBAO TO YBS;

GRANT EXECUTE ON CHAR_TO_LABEL TO GDS;
GRANT EXECUTE ON CHAR_TO_LABEL TO GDCSYT;
GRANT EXECUTE ON CHAR_TO_LABEL TO GDCSYT2;
GRANT EXECUTE ON CHAR_TO_LABEL TO GDCSYT3;
GRANT EXECUTE ON CHAR_TO_LABEL TO YBS;


    