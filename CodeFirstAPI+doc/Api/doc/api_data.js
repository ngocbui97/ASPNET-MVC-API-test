define({ "api": [
  {
    "type": "get",
    "url": "/City/getAll",
    "title": "get all city",
    "group": "City",
    "permission": [
      {
        "name": "none"
      }
    ],
    "version": "1.0.0",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "string",
            "optional": false,
            "field": "MaLop",
            "description": "<p>Ma cua lop moi</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": false,
            "field": "TenLop",
            "description": "<p>Ten cua lop moi</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Request-Example:",
          "content": "{\n     MaLop: '001',\n     TenLop: 'Cong nghe thong tin 01'\n}",
          "type": "json"
        }
      ]
    },
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "MaLop",
            "description": "<p>Ma cua lop moi vua tao</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "TenLop",
            "description": "<p>Ten cua lop moi vua tao</p>"
          },
          {
            "group": "Success 200",
            "type": "long",
            "optional": false,
            "field": "Id",
            "description": "<p>Iid cua lop moi vua tao</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Response:",
          "content": "{\n     Id: 1,\n     MaLop: '001'\n     TenLop: 'Cong nghe thong tin 01'\n}",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "400": [
          {
            "group": "400",
            "type": "string[]",
            "optional": false,
            "field": "Errors",
            "description": "<p>Mang cac loi</p>"
          }
        ]
      },
      "examples": [
        {
          "title": ": {json}",
          "content": "{\n     \"Errors\": [\n         \"Ma lop la truong bat buoc\",\n         \n     ]\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Controllers/CityController.cs",
    "groupTitle": "City",
    "name": "GetCityGetall"
  }
] });
