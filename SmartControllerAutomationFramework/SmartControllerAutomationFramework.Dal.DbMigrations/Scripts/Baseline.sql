CREATE TABLE public."ControllerType"
(
    "Id" uuid NOT NULL,
    "Type" text,
    "SettingsType" text,
    PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
);

CREATE TABLE public."ControllerSettingValues"
(
    "ControllerId" uuid,
    "Name" text,
    "Value" text,
    "Type" text,
    PRIMARY KEY ("ControllerId", "Name")
)
WITH (
    OIDS = FALSE
);


CREATE TABLE public."StorageData"
(
    "ObjectId" uuid,
    "Name" text,
    "Value" text,
    "Type" text,
    PRIMARY KEY ("ObjectId", "Name")
)
WITH (
    OIDS = FALSE
);

CREATE TABLE public."ControllerInstance"
(
    "Id" uuid,
    "TypeId" uuid
)
WITH (
    OIDS = FALSE
);


