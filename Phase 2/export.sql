--------------------------------------------------------
--  File created - Thursday-June-03-2021   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence SEQ_CUSTOMERID
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_CUSTOMERID"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_PHOTOGRAPHERID
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_PHOTOGRAPHERID"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 3 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_SESSIONID
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_SESSIONID"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Table CUSTOMER
--------------------------------------------------------

  CREATE TABLE "CUSTOMER" 
   (	"CNAME" VARCHAR2(50), 
	"CEMAIL" VARCHAR2(50), 
	"CADDRESS" VARCHAR2(50), 
	"CPHONENUMBER" VARCHAR2(11), 
	"CID" NUMBER(*,0)
   ) ;
--------------------------------------------------------
--  DDL for Table PHOTOGRAPHER
--------------------------------------------------------

  CREATE TABLE "PHOTOGRAPHER" 
   (	"PNAME" VARCHAR2(50), 
	"PADDRESS" VARCHAR2(50), 
	"PBIRTHDAY" VARCHAR2(50), 
	"PSALARY" NUMBER(*,0), 
	"PGID" NUMBER(*,0), 
	"PHONENUMBER" VARCHAR2(11)
   ) ;
--------------------------------------------------------
--  DDL for Table SESSIONS
--------------------------------------------------------

  CREATE TABLE "SESSIONS" 
   (	"SESSIONID" NUMBER(*,0), 
	"SESSIONPRICE" NUMBER(*,0), 
	"HEIGHT" NUMBER(*,0), 
	"WIDTH" NUMBER(*,0), 
	"SESSIONDATE" VARCHAR2(50), 
	"PGID" NUMBER(*,0), 
	"CID" NUMBER(*,0)
   ) ;

---------------------------------------------------
--   DATA FOR TABLE PHOTOGRAPHER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PHOTOGRAPHER
Insert into PHOTOGRAPHER (PNAME,PADDRESS,PBIRTHDAY,PSALARY,PGID,PHONENUMBER) values ('mamdouh','Shubra','9/7/2000',10,1,'01065131758');
Insert into PHOTOGRAPHER (PNAME,PADDRESS,PBIRTHDAY,PSALARY,PGID,PHONENUMBER) values ('abdelnasser','al haram ','4/14/2000',3000000,2,'01148150044');

---------------------------------------------------
--   END DATA FOR TABLE PHOTOGRAPHER
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE SESSIONS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into SESSIONS
Insert into SESSIONS (SESSIONID,SESSIONPRICE,HEIGHT,WIDTH,SESSIONDATE,PGID,CID) values (1,20,6,4,'Sunday, June 6, 2021',1,1);
Insert into SESSIONS (SESSIONID,SESSIONPRICE,HEIGHT,WIDTH,SESSIONDATE,PGID,CID) values (2,30,6,4,'Thursday, June 3, 2021',2,2);
Insert into SESSIONS (SESSIONID,SESSIONPRICE,HEIGHT,WIDTH,SESSIONDATE,PGID,CID) values (3,20,6,4,'Wednesday, June 23, 2021',1,3);

---------------------------------------------------
--   END DATA FOR TABLE SESSIONS
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE CUSTOMER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into CUSTOMER
Insert into CUSTOMER (CNAME,CEMAIL,CADDRESS,CPHONENUMBER,CID) values ('abdelnasser','abdo@gmail.com','haram','01264564',1);
Insert into CUSTOMER (CNAME,CEMAIL,CADDRESS,CPHONENUMBER,CID) values ('Ahmed Mamdouh','ahmed@gmail.com','shoubra','01065131758',2);
Insert into CUSTOMER (CNAME,CEMAIL,CADDRESS,CPHONENUMBER,CID) values ('zyad','zyad@gmail.com','aboz3bal','01254569',3);

---------------------------------------------------
--   END DATA FOR TABLE CUSTOMER
---------------------------------------------------
--------------------------------------------------------
--  Constraints for Table CUSTOMER
--------------------------------------------------------

  ALTER TABLE "CUSTOMER" ADD CONSTRAINT "CUSTOMER_UK1" UNIQUE ("CEMAIL") ENABLE;
 
  ALTER TABLE "CUSTOMER" MODIFY ("CEMAIL" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table PHOTOGRAPHER
--------------------------------------------------------

  ALTER TABLE "PHOTOGRAPHER" ADD CONSTRAINT "PHOTOGRAPHER_UK1" UNIQUE ("PHONENUMBER") ENABLE;
 
  ALTER TABLE "PHOTOGRAPHER" MODIFY ("PNAME" NOT NULL ENABLE);
 
  ALTER TABLE "PHOTOGRAPHER" MODIFY ("PADDRESS" NOT NULL ENABLE);
 
  ALTER TABLE "PHOTOGRAPHER" MODIFY ("PSALARY" NOT NULL ENABLE);
 
  ALTER TABLE "PHOTOGRAPHER" MODIFY ("PGID" NOT NULL ENABLE);
 
  ALTER TABLE "PHOTOGRAPHER" MODIFY ("PHONENUMBER" NOT NULL ENABLE);
 
  ALTER TABLE "PHOTOGRAPHER" ADD PRIMARY KEY ("PGID") ENABLE;
--------------------------------------------------------
--  Constraints for Table SESSIONS
--------------------------------------------------------

  ALTER TABLE "SESSIONS" MODIFY ("SESSIONID" NOT NULL ENABLE);
 
  ALTER TABLE "SESSIONS" MODIFY ("SESSIONPRICE" NOT NULL ENABLE);
 
  ALTER TABLE "SESSIONS" MODIFY ("HEIGHT" NOT NULL ENABLE);
 
  ALTER TABLE "SESSIONS" MODIFY ("WIDTH" NOT NULL ENABLE);
 
  ALTER TABLE "SESSIONS" MODIFY ("SESSIONDATE" NOT NULL ENABLE);
 
  ALTER TABLE "SESSIONS" MODIFY ("PGID" NOT NULL ENABLE);
 
  ALTER TABLE "SESSIONS" MODIFY ("CID" NOT NULL ENABLE);
 
  ALTER TABLE "SESSIONS" ADD PRIMARY KEY ("SESSIONID") ENABLE;
--------------------------------------------------------
--  DDL for Index CUSTOMER_UK1
--------------------------------------------------------

  CREATE UNIQUE INDEX "CUSTOMER_UK1" ON "CUSTOMER" ("CEMAIL") 
  ;
--------------------------------------------------------
--  DDL for Index PHOTOGRAPHER_UK1
--------------------------------------------------------

  CREATE UNIQUE INDEX "PHOTOGRAPHER_UK1" ON "PHOTOGRAPHER" ("PHONENUMBER") 
  ;


--------------------------------------------------------
--  Ref Constraints for Table SESSIONS
--------------------------------------------------------

  ALTER TABLE "SESSIONS" ADD FOREIGN KEY ("PGID")
	  REFERENCES "PHOTOGRAPHER" ("PGID") ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRIG_CUSTOMERID
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "TRIG_CUSTOMERID" 
BEFORE INSERT ON CUSTOMER
FOR EACH ROW

BEGIN
  SELECT SEQ_CUSTOMERID.NEXTVAL
  INTO   :new.CID
  FROM   dual;
END;

/
ALTER TRIGGER "TRIG_CUSTOMERID" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRIG_PHOTOGRAPHERID
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "TRIG_PHOTOGRAPHERID" 
BEFORE INSERT ON PhotoGrapher
FOR EACH ROW

BEGIN
  SELECT seq_photographerID.NEXTVAL
  INTO   :new.PGID
  FROM   dual;
END;
/
ALTER TRIGGER "TRIG_PHOTOGRAPHERID" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRIG_SESSIONID
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "TRIG_SESSIONID" 
BEFORE INSERT ON SESSIONS
FOR EACH ROW

BEGIN
  SELECT SEQ_SESSIONID.NEXTVAL
  INTO   :new.SESSIONID
  FROM   dual;
END;
/
ALTER TRIGGER "TRIG_SESSIONID" ENABLE;
--------------------------------------------------------
--  DDL for Procedure GETPHOTOGRAPHER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GETPHOTOGRAPHER" 
(pcursor out sys_refcursor)
as 
BEGIN
open pcursor for 
select pname , PGID
from photographer;
END;

/

--------------------------------------------------------
--  DDL for Procedure GETPHOTOGRAPHERID
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GETPHOTOGRAPHERID" 
(phone in VARCHAR2 ,pid out NUMBER)
as 
BEGIN
select PGID 
into pid
from photographer
where phone = PHONENUMBER;
end;

/

