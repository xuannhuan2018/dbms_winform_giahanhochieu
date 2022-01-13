/* TAO CAC USER CAN THIET*/

CREATE USER PASSPORT
    IDENTIFIED BY PASSPORT
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
CREATE USER RESIDENT
    IDENTIFIED BY RESIDENT
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
-- 1
CREATE USER XTQUAN01
    IDENTIFIED BY XTQUAN01
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--2    
CREATE USER XTQUAN02
    IDENTIFIED BY XTQUAN02
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--3    
CREATE USER XTQUAN03
    IDENTIFIED BY XTQUAN03
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--4    
CREATE USER XTQUAN04
    IDENTIFIED BY XTQUAN04
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--5    
CREATE USER XTQUAN05
    IDENTIFIED BY XTQUAN05
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--6    
CREATE USER XTQUAN06
    IDENTIFIED BY XTQUAN06
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--7    
CREATE USER XTQUAN07
    IDENTIFIED BY XTQUAN07
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--8
CREATE USER XTQUAN08
    IDENTIFIED BY XTQUAN08
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--9
CREATE USER XTQUAN09
    IDENTIFIED BY XTQUAN09
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--10
CREATE USER XTQUAN10
    IDENTIFIED BY XTQUAN10
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--11
CREATE USER XTQUAN11
    IDENTIFIED BY XTQUAN11
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--12
CREATE USER XTQUAN12
    IDENTIFIED BY XTQUAN12
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--13
CREATE USER XTQUANTHUDUC
    IDENTIFIED BY XTQUANTHUDUC
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--14    
CREATE USER XTQUANBINHTHANH
    IDENTIFIED BY XTQUANBINHTHANH
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--15
CREATE USER XTQUANTANPHU
    IDENTIFIED BY XTQUANTANPHU
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;

--16    
CREATE USER XTQUANGOVAP
    IDENTIFIED BY XTQUANGOVAP
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--17 
CREATE USER XTQUANBINHTAN
    IDENTIFIED BY XTQUANBINHTAN
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--18
CREATE USER XTQUANPHUNHUAN
    IDENTIFIED BY XTQUANPHUNHUAN
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--19
CREATE USER XTQUANTANBINH
    IDENTIFIED BY XTQUANTANBINH
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--20
CREATE USER XTQUANBINHCHANH
    IDENTIFIED BY XTQUANBINHCHANH
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--21
CREATE USER XTQUANCANGIO
    IDENTIFIED BY XTQUANCANGIO
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--22
CREATE USER XTQUANCUCHI
    IDENTIFIED BY XTQUANCUCHI
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--23
CREATE USER XTQUANHOOCMON
    IDENTIFIED BY XTQUANHOOCMON
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;
    
--24
CREATE USER XTQUANNHABE
    IDENTIFIED BY XTQUANNHABE
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;

--25: User lam nhiem vu luu tru va gia han ho chieu    
CREATE USER BPLUUTRU
    IDENTIFIED BY BPLUUTRU
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;

--26: User lam nhiem vu xet duyet    
CREATE USER BPXETDUYET
    IDENTIFIED BY BPXETDUYET
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;

--27: User lam nhiem vu giam sat    
CREATE USER BPGIAMSAT
    IDENTIFIED BY BPGIAMSAT
    DEFAULT TABLESPACE USERS
    QUOTA 50M ON USERS;

/* CAP CAC QUYEN CAN THIET CHO CAC USER TREN CAC TABLE*/

GRANT CREATE SESSION TO 
    XTQUAN01, XTQUAN02, XTQUAN03, XTQUAN04, XTQUAN05, XTQUAN06, XTQUAN07, XTQUAN08, 
    XTQUAN09, XTQUAN10, XTQUAN11, XTQUAN12, XTQUANBINHTAN, XTQUANBINHTHANH, XTQUANGOVAP, XTQUANPHUNHUAN, 
    XTQUANTANBINH, XTQUANTANPHU, XTQUANTHUDUC, XTQUANBINHCHANH, XTQUANCANGIO, XTQUANCUCHI, XTQUANHOOCMON, XTQUANNHABE,
    BPLUUTRU, BPGIAMSAT, BPXETDUYET;
    
CREATE ROLE XACTHUC;

GRANT XACTHUC TO XTQUAN01, XTQUAN02, XTQUAN03, XTQUAN04, XTQUAN05, XTQUAN06, XTQUAN07, XTQUAN08, 
    XTQUAN09, XTQUAN10, XTQUAN11, XTQUAN12, XTQUANBINHTAN, XTQUANBINHTHANH, XTQUANGOVAP, XTQUANPHUNHUAN, 
    XTQUANTANBINH, XTQUANTANPHU, XTQUANTHUDUC, XTQUANBINHCHANH, XTQUANCANGIO, XTQUANCUCHI, XTQUANHOOCMON, XTQUANNHABE;
    
CREATE ROLE XETDUYET;

GRANT XETDUYET TO BPXETDUYET;

CREATE ROLE LUUTRU;
    
GRANT LUUTRU TO BPLUUTRU;

CREATE ROLE GIAMSAT;

GRANT GIAMSAT TO BPGIAMSAT;

GRANT SELECT, UPDATE, DELETE, INSERT ON PASSPORT.DSGIAHANHOCHIEU TO 
    XTQUAN01, XTQUAN02, XTQUAN03, XTQUAN04, XTQUAN05, XTQUAN06, XTQUAN07, XTQUAN08, 
    XTQUAN09, XTQUAN10, XTQUAN11, XTQUAN12, XTQUANBINHTAN, XTQUANBINHTHANH, XTQUANGOVAP, XTQUANPHUNHUAN, 
    XTQUANTANBINH, XTQUANTANPHU, XTQUANTHUDUC, XTQUANBINHCHANH, XTQUANCANGIO, XTQUANCUCHI, XTQUANHOOCMON, XTQUANNHABE,
    BPLUUTRU, BPGIAMSAT, BPXETDUYET;
    
GRANT SELECT, UPDATE, DELETE, INSERT ON RESIDENT.TTCONGDANHCM TO 
    XTQUAN01, XTQUAN02, XTQUAN03, XTQUAN04, XTQUAN05, XTQUAN06, XTQUAN07, XTQUAN08, 
    XTQUAN09, XTQUAN10, XTQUAN11, XTQUAN12, XTQUANBINHTAN, XTQUANBINHTHANH, XTQUANGOVAP, XTQUANPHUNHUAN, 
    XTQUANTANBINH, XTQUANTANPHU, XTQUANTHUDUC, XTQUANBINHCHANH, XTQUANCANGIO, XTQUANCUCHI, XTQUANHOOCMON, XTQUANNHABE,
    BPLUUTRU, BPGIAMSAT, BPXETDUYET;
    
GRANT SELECT, UPDATE, DELETE, INSERT ON RESIDENT.TTHOCHIEU TO 
    XTQUAN01, XTQUAN02, XTQUAN03, XTQUAN04, XTQUAN05, XTQUAN06, XTQUAN07, XTQUAN08, 
    XTQUAN09, XTQUAN10, XTQUAN11, XTQUAN12, XTQUANBINHTAN, XTQUANBINHTHANH, XTQUANGOVAP, XTQUANPHUNHUAN, 
    XTQUANTANBINH, XTQUANTANPHU, XTQUANTHUDUC, XTQUANBINHCHANH, XTQUANCANGIO, XTQUANCUCHI, XTQUANHOOCMON, XTQUANNHABE,
    BPLUUTRU, BPGIAMSAT, BPXETDUYET;

--------------------------------------------------------------------------------------------------------------------------------------------------------
begin
    dbms_rls.drop_policy
    (
        object_schema      =>'PASSPORT' 
        ,object_name        =>'DSGIAHANHOCHIEU'  
        ,policy_name        =>'NOUPDATEXT_DSGIAHANHOCHIEU' 
    );
end;

SELECT * FROM dba_policies;

drop role BPXACTHUC;
---------------------------------------------------------------------------------------------------------------------------------------------------------------

/*SELECT*/

create or replace function FN_S_dsgiahanhochieu (p_schema varchar2, p_obj varchar2)
return varchar2 as
    l_user varchar2(20);
begin
    l_user := SYS_CONTEXT('userenv', 'SESSION_USER');
    
    if (l_user = 'XTQUAN01') then
        return 'quanhuyen=' || '''' || 'Qu?n 1' || '''';
    elsif (l_user = 'XTQUAN02') then
        return 'quanhuyen=' || '''' || 'Qu?n 2' || '''';
    elsif (l_user = 'XTQUAN03') then
        return 'quanhuyen=' || '''' || 'Qu?n 3' || '''';
    elsif (l_user = 'XTQUAN04') then
        return 'quanhuyen=' || '''' || 'Qu?n 4' || '''';
    elsif (l_user = 'XTQUAN05') then
        return 'quanhuyen=' || '''' || 'Qu?n 5' || '''';
    elsif (l_user = 'XTQUAN06') then
        return 'quanhuyen=' || '''' || 'Qu?n 6' || '''';
    elsif (l_user = 'XTQUAN07') then
        return 'quanhuyen=' || '''' || 'Qu?n 7' || '''';
    elsif (l_user = 'XTQUAN08') then
        return 'quanhuyen=' || '''' || 'Qu?n 8' || '''';
    elsif (l_user = 'XTQUAN09') then
        return 'quanhuyen=' || '''' || 'Qu?n 9' || '''';
    elsif (l_user = 'XTQUAN10') then
        return 'quanhuyen=' || '''' || 'Qu?n 10' || '''';
    elsif (l_user = 'XTQUAN11') then
        return 'quanhuyen=' || '''' || 'Qu?n 11' || '''';
    elsif (l_user = 'XTQUAN12') then
        return 'quanhuyen=' || '''' || 'Qu?n 12' || '''';
    elsif (l_user = 'XTQUANBINHTAN') then
        return 'quanhuyen=' || '''' || 'Qu?n Bình Tân' || '''';
    elsif (l_user = 'XTQUANBINHTHANH') then
        return 'quanhuyen=' || '''' || 'Qu?n Bình Th?nh' || '''';
    elsif (l_user = 'XTQUANGOVAP') then
        return 'quanhuyen=' || '''' || 'Qu?n Gò V?p' || '''';
    elsif (l_user = 'XTQUANPHUNHUAN') then
        return 'quanhuyen=' || '''' || 'Qu?n Phú Nhu?n' || '''';
    elsif (l_user = 'XTQUANTANBINH') then
        return 'quanhuyen=' || '''' || 'Qu?n Tân Bình' || '''';
    elsif (l_user = 'XTQUANTANPHU') then
        return 'quanhuyen=' || '''' || 'Qu?n Tân Phú' || '''';
    elsif (l_user = 'XTQUANTHUDUC') then
        return 'quanhuyen=' || '''' || 'Qu?n Th? ??c' || '''';
    elsif (l_user = 'XTQUANBINHCHANH') then
        return 'quanhuyen=' || '''' || 'Huy?n Bình Chánh' || '''';
    elsif (l_user = 'XTQUANCANGIO') then
        return 'quanhuyen=' || '''' || 'Huy?n C?n Gi?' || '''';
    elsif (l_user = 'XTQUANCUCHI') then
        return 'quanhuyen=' || '''' || 'Huy?n C? Chi' || '''';
    elsif (l_user = 'XTQUANHOOCMON') then
        return 'quanhuyen=' || '''' || 'Huy?n Hóc Môn' || '''';
    elsif (l_user = 'XTQUANNHABE') then
        return 'quanhuyen=' || '''' || 'Huy?n Nhà Bè' || '''';
    elsif (l_user = 'BPXETDUYET') then
        return 'ttxacthuc=' || '''' || '?ã xác th?c' || '''';
    elsif (l_user = 'BPLUUTRU') then
        return 'ttxetduyet is not null';
    else
        return '1=0';
    end if;
    EXCEPTION 
        WHEN OTHERS THEN RETURN '1=0';
end;

begin
    dbms_rls.add_policy
    (
        object_schema      =>'PASSPORT' 
        ,object_name        =>'DSGIAHANHOCHIEU'  
        ,policy_name        =>'S_dsgiahanhochieu' 
        ,policy_function    =>'FN_S_dsgiahanhochieu'
        ,statement_Types    =>'SELECT'
        ,update_check        => TRUE
    );
end;


create or replace function FN_BPLT_NoSel_dsgiahanhochieu (p_schema varchar2, p_obj varchar2)
return varchar2 as
    l_user varchar2(20);
begin
    l_user := SYS_CONTEXT('userenv', 'SESSION_USER'); 
    if (l_user = 'BPLUUTRU') then
        return '1=0';
    else
        return '1=1';
    end if;
    EXCEPTION 
        WHEN OTHERS THEN RETURN '1=0';
end;

begin
    dbms_rls.add_policy
    (
        object_schema      =>'PASSPORT' 
        ,object_name        =>'DSGIAHANHOCHIEU'  
        ,policy_name        =>'BPLT_NoSel_dsgiahanhochieu' 
        ,policy_function    =>'FN_BPLT_NoSel_dsgiahanhochieu'
        ,statement_Types    =>'SELECT'
        ,sec_relevant_cols => 'HOTEN, NGAYSINH, GIOITINH, CMND, DIACHI, PHUONG, QUANHUYEN, SDT, EMAIL, TTXACTHUC, COMMENTS'
        ,sec_relevant_cols_opt => DBMS_RLS.all_rows
        ,update_check        => TRUE
    );
end;

/*UPDATE*/

create or replace function FN_Update_dsgiahanhochieu (p_schema varchar2, p_obj varchar2)
return varchar2 as
    l_user varchar2(20);
begin
    l_user := SYS_CONTEXT('userenv', 'SESSION_USER');
    
    if (l_user = 'XTQUAN01') then
        return 'quanhuyen=' || '''' || 'Qu?n 1' || '''';
    elsif (l_user = 'XTQUAN02') then
        return 'quanhuyen=' || '''' || 'Qu?n 2' || '''';
    elsif (l_user = 'XTQUAN03') then
        return 'quanhuyen=' || '''' || 'Qu?n 3' || '''';
    elsif (l_user = 'XTQUAN04') then
        return 'quanhuyen=' || '''' || 'Qu?n 4' || '''';
    elsif (l_user = 'XTQUAN05') then
        return 'quanhuyen=' || '''' || 'Qu?n 5' || '''';
    elsif (l_user = 'XTQUAN06') then
        return 'quanhuyen=' || '''' || 'Qu?n 6' || '''';
    elsif (l_user = 'XTQUAN07') then
        return 'quanhuyen=' || '''' || 'Qu?n 7' || '''';
    elsif (l_user = 'XTQUAN08') then
        return 'quanhuyen=' || '''' || 'Qu?n 8' || '''';
    elsif (l_user = 'XTQUAN09') then
        return 'quanhuyen=' || '''' || 'Qu?n 9' || '''';
    elsif (l_user = 'XTQUAN10') then
        return 'quanhuyen=' || '''' || 'Qu?n 10' || '''';
    elsif (l_user = 'XTQUAN11') then
        return 'quanhuyen=' || '''' || 'Qu?n 11' || '''';
    elsif (l_user = 'XTQUAN12') then
        return 'quanhuyen=' || '''' || 'Qu?n 12' || '''';
    elsif (l_user = 'XTQUANBINHTAN') then
        return 'quanhuyen=' || '''' || 'Qu?n Bình Tân' || '''';
    elsif (l_user = 'XTQUANBINHTHANH') then
        return 'quanhuyen=' || '''' || 'Qu?n Bình Th?nh' || '''';
    elsif (l_user = 'XTQUANGOVAP') then
        return 'quanhuyen=' || '''' || 'Qu?n Gò V?p' || '''';
    elsif (l_user = 'XTQUANPHUNHUAN') then
        return 'quanhuyen=' || '''' || 'Qu?n Phú Nhu?n' || '''';
    elsif (l_user = 'XTQUANTANBINH') then
        return 'quanhuyen=' || '''' || 'Qu?n Tân Bình' || '''';
    elsif (l_user = 'XTQUANTANPHU') then
        return 'quanhuyen=' || '''' || 'Qu?n Tân Phú' || '''';
    elsif (l_user = 'XTQUANTHUDUC') then
        return 'quanhuyen=' || '''' || 'Qu?n Th? ??c' || '''';
    elsif (l_user = 'XTQUANBINHCHANH') then
        return 'quanhuyen=' || '''' || 'Huy?n Bình Chánh' || '''';
    elsif (l_user = 'XTQUANCANGIO') then
        return 'quanhuyen=' || '''' || 'Huy?n C?n Gi?' || '''';
    elsif (l_user = 'XTQUANCUCHI') then
        return 'quanhuyen=' || '''' || 'Huy?n C? Chi' || '''';
    elsif (l_user = 'XTQUANHOOCMON') then
        return 'quanhuyen=' || '''' || 'Huy?n Hóc Môn' || '''';
    elsif (l_user = 'XTQUANNHABE') then
        return 'quanhuyen=' || '''' || 'Huy?n Nhà Bè' || '''';
    elsif (l_user = 'BPXETDUYET') then
        return 'ttxacthuc=' || '''' || '?ã xác th?c' || '''';
    else
        return '1=0';
  end if;
  EXCEPTION 
        WHEN OTHERS THEN RETURN '1=0';
end;

begin
    dbms_rls.add_policy
    (
        object_schema      =>'PASSPORT' 
        ,object_name        =>'DSGIAHANHOCHIEU'  
        ,policy_name        =>'Update_dsgiahanhochieu' 
        ,policy_function    =>'FN_Update_dsgiahanhochieu'
        ,statement_Types    =>'UPDATE'
        ,update_check        => TRUE
    );
end;

create or replace function FN_NoUpdatext_dsgiahanhochieu (p_schema varchar2, p_obj varchar2)
return varchar2 as
    l_user varchar2(20);
begin
    l_user := SYS_CONTEXT('userenv', 'SESSION_USER'); 
    if (l_user = 'BPXETDUYET') then
        return '1=1';
    else
        return '1=0';
    
    end if;
    EXCEPTION 
        WHEN OTHERS THEN RETURN '1=0';
end;

begin
    dbms_rls.add_policy
    (
        object_schema      =>'PASSPORT' 
        ,object_name        =>'DSGIAHANHOCHIEU'  
        ,policy_name        =>'NoUpdatext_dsgiahanhochieu' 
        ,policy_function    =>'FN_NoUpdatext_dsgiahanhochieu'
        ,statement_Types    =>'UPDATE'
        ,sec_relevant_cols => 'NGAYDK, HOTEN, NGAYSINH, GIOITINH, CMND, DIACHI, PHUONG, QUANHUYEN, SDT, EMAIL, MAHOCHIEU, TTXETDUYET'
        ,update_check        => TRUE
    );
end;

create or replace function FN_NoUpdatexd_dsgiahanhochieu (p_schema varchar2, p_obj varchar2)
return varchar2 as
    l_user varchar2(20);
begin
    l_user := SYS_CONTEXT('userenv', 'SESSION_USER'); 
    if (l_user = 'BPXETDUYET') then
        return '1=0';
    else
        return '1=1';
    end if;
    EXCEPTION 
        WHEN OTHERS THEN RETURN '1=0';
end;

begin
    dbms_rls.add_policy
    (
        object_schema      =>'PASSPORT' 
        ,object_name        =>'DSGIAHANHOCHIEU'  
        ,policy_name        =>'NoUpdatexd_dsgiahanhochieu' 
        ,policy_function    =>'FN_NoUpdatexd_dsgiahanhochieu'
        ,statement_Types    =>'UPDATE'
        ,sec_relevant_cols => 'NGAYDK, HOTEN, NGAYSINH, GIOITINH, CMND, DIACHI, PHUONG, QUANHUYEN, SDT, EMAIL, MAHOCHIEU, TTXACTHUC, COMMENTS'
        ,update_check        => TRUE
    );
end;

/*INSERT*/

create or replace function FN_Insert_dsgiahanhochieu (p_schema varchar2, p_obj varchar2)
return varchar2 as
    l_user varchar2(20);
begin
    l_user := SYS_CONTEXT('userenv', 'SESSION_USER'); 
    if (l_user = 'PASSPORT') then
        return '1=1';
    else
        return '1=0';
    end if;
    EXCEPTION 
        WHEN OTHERS THEN RETURN '1=0';
end;

begin
    dbms_rls.add_policy
    (
        object_schema      =>'PASSPORT' 
        ,object_name        =>'DSGIAHANHOCHIEU'  
        ,policy_name        =>'Insert_dsgiahanhochieu' 
        ,policy_function    =>'FN_Insert_dsgiahanhochieu'
        ,statement_Types    =>'INSERT'
        ,update_check        => TRUE
    );
end;

/*DELETE*/

create or replace function FN_Delete_dsgiahanhochieu (p_schema varchar2, p_obj varchar2)
return varchar2 as
    l_user varchar2(20);
begin
    return '1=0';
end;

begin
    dbms_rls.add_policy
    (
        object_schema      =>'PASSPORT' 
        ,object_name        =>'DSGIAHANHOCHIEU'  
        ,policy_name        =>'Delete_dsgiahanhochieu' 
        ,policy_function    =>'FN_Delete_dsgiahanhochieu'
        ,statement_Types    =>'delete'
        ,update_check        => TRUE
    );
end;

-----------------------------------------------------------------------------------------------------------------------

/*SELECT*/
create or replace function FN_Select_ttcongdanhcm (p_schema varchar2, p_obj varchar2)
return varchar2 as
    l_user varchar2(20);
begin
    l_user := SYS_CONTEXT('userenv', 'SESSION_USER');
    
    if (l_user = 'XTQUAN01') then
        return 'quanhuyen=' || '''' || 'Qu?n 1' || '''';
    elsif (l_user = 'XTQUAN02') then
        return 'quanhuyen=' || '''' || 'Qu?n 2' || '''';
    elsif (l_user = 'XTQUAN03') then
        return 'quanhuyen=' || '''' || 'Qu?n 3' || '''';
    elsif (l_user = 'XTQUAN04') then
        return 'quanhuyen=' || '''' || 'Qu?n 4' || '''';
    elsif (l_user = 'XTQUAN05') then
        return 'quanhuyen=' || '''' || 'Qu?n 5' || '''';
    elsif (l_user = 'XTQUAN06') then
        return 'quanhuyen=' || '''' || 'Qu?n 6' || '''';
    elsif (l_user = 'XTQUAN07') then
        return 'quanhuyen=' || '''' || 'Qu?n 7' || '''';
    elsif (l_user = 'XTQUAN08') then
        return 'quanhuyen=' || '''' || 'Qu?n 8' || '''';
    elsif (l_user = 'XTQUAN09') then
        return 'quanhuyen=' || '''' || 'Qu?n 9' || '''';
    elsif (l_user = 'XTQUAN10') then
        return 'quanhuyen=' || '''' || 'Qu?n 10' || '''';
    elsif (l_user = 'XTQUAN11') then
        return 'quanhuyen=' || '''' || 'Qu?n 11' || '''';
    elsif (l_user = 'XTQUAN12') then
        return 'quanhuyen=' || '''' || 'Qu?n 12' || '''';
    elsif (l_user = 'XTQUANBINHTAN') then
        return 'quanhuyen=' || '''' || 'Qu?n Bình Tân' || '''';
    elsif (l_user = 'XTQUANBINHTHANH') then
        return 'quanhuyen=' || '''' || 'Qu?n Bình Th?nh' || '''';
    elsif (l_user = 'XTQUANGOVAP') then
        return 'quanhuyen=' || '''' || 'Qu?n Gò V?p' || '''';
    elsif (l_user = 'XTQUANPHUNHUAN') then
        return 'quanhuyen=' || '''' || 'Qu?n Phú Nhu?n' || '''';
    elsif (l_user = 'XTQUANTANBINH') then
        return 'quanhuyen=' || '''' || 'Qu?n Tân Bình' || '''';
    elsif (l_user = 'XTQUANTANPHU') then
        return 'quanhuyen=' || '''' || 'Qu?n Tân Phú' || '''';
    elsif (l_user = 'XTQUANTHUDUC') then
        return 'quanhuyen=' || '''' || 'Qu?n Th? ??c' || '''';
    elsif (l_user = 'XTQUANBINHCHANH') then
        return 'quanhuyen=' || '''' || 'Huy?n Bình Chánh' || '''';
    elsif (l_user = 'XTQUANCANGIO') then
        return 'quanhuyen=' || '''' || 'Huy?n C?n Gi?' || '''';
    elsif (l_user = 'XTQUANCUCHI') then
        return 'quanhuyen=' || '''' || 'Huy?n C? Chi' || '''';
    elsif (l_user = 'XTQUANHOOCMON') then
        return 'quanhuyen=' || '''' || 'Huy?n Hóc Môn' || '''';
    elsif (l_user = 'XTQUANNHABE') then
        return 'quanhuyen=' || '''' || 'Huy?n Nhà Bè' || '''';
    else
        return '1=0';
  end if;
  EXCEPTION 
        WHEN OTHERS THEN RETURN '1=0';
end;

begin
    dbms_rls.add_policy
    (
        object_schema      =>'RESIDENT' 
        ,object_name        =>'TTCONGDANHCM'  
        ,policy_name        =>'Select_ttcongdanhcm' 
        ,policy_function    =>'FN_Select_ttcongdanhcm'
        ,statement_Types    =>'SELECT'
        ,update_check        => TRUE
    );
end;

/*INSERT, DELETE, UPDATE*/
create or replace function FN_CUD_ttcongdanhcm (p_schema varchar2, p_obj varchar2)
return varchar2 as
    l_user varchar2(20);
begin
    return '1=0';
end;

begin
    dbms_rls.add_policy
    (
        object_schema      =>'RESIDENT' 
        ,object_name        =>'TTCONGDANHCM'  
        ,policy_name        =>'CUD_ttcongdanhcm' 
        ,policy_function    =>'FN_CUD_ttcongdanhcm'
        ,statement_Types    =>'INSERT, DELETE, UPDATE'
        ,update_check        => TRUE
    );
end;

------------------------------------------------------------------------------------------------------------------------------------

/*SELECT*/

create or replace function FN_Select_tthochieu (p_schema varchar2, p_obj varchar2)
return varchar2 as
    l_user VARCHAR2(128);
begin
    l_user := SYS_CONTEXT('userenv', 'SESSION_USER');
    
    IF(l_user = 'BPLUUTRU') then
        return '1=1';
    ELSIF ((l_user = 'BPXETDUYET') OR (l_user = 'BPGIAMSAT') OR (l_user = 'PASSPORT') OR (l_user = 'RESIDENT')) then
        return '1=0';
    ELSE
        return 'cmnd IN (SELECT cmnd FROM RESIDENT.ttcongdanhcm)';
    END IF;
end;

begin
    dbms_rls.add_policy
    (
        object_schema      =>'RESIDENT' 
        ,object_name        =>'TTHOCHIEU'  
        ,policy_name        =>'Select_tthochieu' 
        ,policy_function    =>'FN_Select_tthochieu'
        ,statement_Types    =>'SELECT'
        ,update_check        => TRUE
    );
end;

/*UPDATE*/
create or replace function FN_Update_tthochieu (p_schema varchar2, p_obj varchar2)
return varchar2 as
    l_user VARCHAR2(128);
begin
    l_user := SYS_CONTEXT('userenv', 'SESSION_USER');
    
    IF(l_user = 'BPLUUTRU') then
        return '1=1';
    ELSE
        return '1=0';
    END IF;
end;

begin
    dbms_rls.add_policy
    (
        object_schema      =>'RESIDENT' 
        ,object_name        =>'TTHOCHIEU'  
        ,policy_name        =>'Update_tthochieu' 
        ,policy_function    =>'FN_Update_tthochieu'
        ,statement_Types    =>'Update'
        ,update_check        => TRUE
    );
end;

/*INSERT, DELETE*/
create or replace function FN_InsDel_tthochieu (p_schema varchar2, p_obj varchar2)
return varchar2 as
    l_user VARCHAR2(128);
begin
    return '1=0';
end;

begin
    dbms_rls.add_policy
    (
        object_schema      =>'RESIDENT' 
        ,object_name        =>'TTHOCHIEU'  
        ,policy_name        =>'InsDel_tthochieu' 
        ,policy_function    =>'FN_InsDel_tthochieu'
        ,statement_Types    =>'INSERT, DELETE'
        ,update_check        => TRUE
    );
end;

