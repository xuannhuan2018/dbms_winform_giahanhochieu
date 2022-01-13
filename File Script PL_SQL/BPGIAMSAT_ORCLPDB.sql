BEGIN 
    DBMS_FGA.ADD_POLICY
    ( 
        object_schema  => 'PASSPORT', 
        object_name    => 'dsgiahanhochieu', 
        policy_name    => 'passport_audit_2021', 
        audit_condition => NULL,  
        statement_types => 'INSERT,UPDATE', 
        audit_trail  => DBMS_FGA.DB+DBMS_FGA.EXTENDED
    ); 
END; 

SELECT transactionid as ID, TO_CHAR(extended_timestamp, 'DD-MM-YYYY HH24:MI:SS') as Time, current_user as Username, userhost as Hostname, statement_type as Type, sql_text FROM DBA_FGA_AUDIT_TRAIL ORDER BY extended_timestamp DESC;