drop database if exists gestion_stock;
create database gestion_stock;
use gestion_stock;


create table clients (
codeCli varchar(32) primary key,
nomCli varchar(65)) engine= Innodb;

create table fournisseurs (
codeFrs varchar(32) primary key,
nomFrs varchar(65)) engine= Innodb;


create table commandesVente (idCMV int auto_increment primary key,
dateCM DATE,
codeCli varchar(32),
constraint fk_Comm_Client foreign key (codeCli) 
references clients(codeCli)) engine= Innodb;

create table commandesAchat (idCMA int auto_increment primary key,
dateCM DATE,
codeFrs varchar(32),
constraint fk_Comm_Frs foreign key (codeFrs) 
references fournisseurs(codeFrs)) engine= Innodb;


create table produit (
designation varchar(65),
refProd varchar(32) primary key ,
PU float ) engine= Innodb;

create table detailsVente (
numCMV int,
refProd varchar(32),
qte varchar(32),
PU varchar(32),
date DATE,
TVA float,
remise float,
port varchar(32),
client varchar(32),
adrDeLivr varchar(65),
constraint pk_COMM_PROD primary key (numCMV,refProd)) engine= Innodb;

create table detailsAchat (
numCMA int,
refProd varchar(32),
qte varchar(32),
PU varchar(32),
date DATE,
TVA float,
remise float,
port varchar(32),
fournisseur varchar(32),
constraint pk_COMM_PROD primary key (numCMA,refProd)) engine= Innodb;

alter table detailsVente add constraint fk_comm_vent foreign key (numCMV)
references commandesVente(idCMV);

alter table detailsAchat add constraint fk_comm_acht foreign key (numCMA)
references commandesAchat(idCMA);

alter table detailsVente add constraint fk_details_prod foreign key (refProd)
references produit(refProd);

create table users(
login varchar(52),
password varchar(52));

insert into users(login,password) values ('admin','kogachuko');

insert into produit values ('camera','1000','40000');
insert into produit values ('ventilateur','1001','5000');
insert into produit values ('ordinateur','1002','250000');
insert into produit values ('moto','1003','200000');
insert into produit values ('smartphone','1004','99000');
insert into produit values ('voiture','1005','8000000');