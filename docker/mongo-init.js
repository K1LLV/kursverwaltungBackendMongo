db.createCollection("lernende", {
  validator: {
    $jsonSchema: {
      bsonType: "object",
      title: "Student Object Validation",
      properties: {
        vorname: {
          bsonType: "string",
          description: "'vorname' must be a string.",
        },
        nachname: {
          bsonType: "string",
          description: "'nachname' must be a string.",
        },
        strasse: {
          bsonType: "string",
          description: "'strasse' must be a string and is required.",
        },
        plz: {
          bsonType: "string",
          description: "'plz' must be a string.",
        },
        ort: {
          bsonType: "string",
          description: "'ort' must be a string and is required.",
        },
        fk_id_land: {
          bsonType: "string",
          description: "'le_email' must be a string and is required.",
        },
        geschlecht: {
          bsonType: "string",
          description: "'geschlecht' must be a string.",
        },
        telefon: {
          bsonType: "string",
          description: "'telefon' must be a string.",
        },
        handy: {
          bsonType: "date",
          description: "'handy' must be a Date and is required.",
        },
        email: {
          bsonType: "string",
          description: "'email' must be a string.",
        },
        email_privat: {
          bsonType: "string",
          description: "'email_privat' must be a string.",
        },
        birthdate: {
          bsonType: "date",
          description: "'birthdate' must be a date.",
        },
      },
    },
  },
});

db.createCollection("dozenten", {
  validator: {
    $jsonSchema: {
      bsonType: "object",
      title: "Student Object Validation",
      properties: {
        vorname: {
          bsonType: "string",
          description: "'vorname' must be a string.",
        },
        nachname: {
          bsonType: "string",
          description: "'nachname' must be a string.",
        },
        strasse: {
          bsonType: "string",
          description: "'strasse' must be a string and is required.",
        },
        plz: {
          bsonType: "string",
          description: "'plz' must be a string.",
        },
        ort: {
          bsonType: "string",
          description: "'ort' must be a string and is required.",
        },
        fk_id_land: {
          bsonType: "string",
          description: "'fk_id_land' must be a string and is required.",
        },
        geschlecht: {
          bsonType: "string",
          description: "'geschlecht' must be a string.",
        },
        telefon: {
          bsonType: "string",
          description: "'telefon' must be a string.",
        },
        handy: {
          bsonType: "date",
          description: "'handy' must be a Date and is required.",
        },
        email: {
          bsonType: "string",
          description: "'email' must be a string.",
        },
        birthdate: {
          bsonType: "date",
          description: "'birthdate' must be a date.",
        },
      },
    },
  },
});

db.createCollection("laender", {
  validator: {
    $jsonSchema: {
      bsonType: "object",
      title: "lehrbetriebe Object Validation",
      properties: {
        land: {
          bsonType: "string",
          description: "'land' must be a string and is required.",
        },
      },
    },
  },
});

db.createCollection("lehrbetriebe", {
  validator: {
    $jsonSchema: {
      bsonType: "object",
      title: "lehrbetriebe Object Validation",
      properties: {
        firma: {
          bsonType: "string",
          description: "'firma' must be a string and is required.",
        },
        strasse: {
          bsonType: "string",
          description: "'strasse' must be a string and is required.",
        },
        plz: {
          bsonType: "string",
          description: "'plz' must be a string and is required.",
        },
        ort: {
          bsonType: "string",
          description: "'ort' must be a string and is required.",
        },
      },
    },
  },
});

db.createCollection("lehrbetrieb_lernende", {
  validator: {
    $jsonSchema: {
      bsonType: "object",
      title: "lehrbetrieb_lernende Object Validation",
      properties: {
        fk_id_lehrbetrieb: {
          bsonType: "string",
          description: "'fk_id_lehrbetrieb' must be a string and is required.",
        },
        fk_id_lernende: {
          bsonType: "string",
          description: "'fk_id_lernende' must be an string and is required.",
        },
        start: {
          bsonType: "date",
          description: "'start' must be an date and is required.",
        },
        ende: {
          bsonType: "date",
          description: "'ende' must be an date and is required.",
        },
      },
    },
  },
});

db.createCollection("kurse", {
  validator: {
    $jsonSchema: {
      bsonType: "object",
      title: "kurse Object Validation",
      properties: {
        kursnummer: {
          bsonType: "string",
          description: "'kursnummer' must be a string.",
        },
        kursthema: {
          bsonType: "string",
          description: "'kursthema' must be a string.",
        },
        inhalt: {
          bsonType: "string",
          description: "'inhalt' must be a string.",
        },
        fk_id_dozent: {
          bsonType: "string",
          description: "'fk_id_dozent' must be a string.",
        },
        start: {
          bsonType: "date",
          description: "'start' must be an date and is required.",
        },
        ende: {
          bsonType: "date",
          description: "'ende' must be an date and is required.",
        },
      },
    },
  },
});

db.createCollection("kurse_lernende", {
  validator: {
    $jsonSchema: {
      bsonType: "object",
      title: "kurse_lernende Object Validation",
      properties: {
        fk_id_kurs: {
          bsonType: "string",
          description: "'fk_id_lehrbetrieb' must be a string and is required.",
        },
        fk_id_lernende: {
          bsonType: "string",
          description: "'fk_id_lernende' must be an string and is required.",
        },
        note: {
          bsonType: "double",
          description: "'note' must be a double and is required.",
        },
      },
    },
  },
});
