using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using unirest_net;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace BarcodEZ_Software
{
    class Json
    {
        string Asin { get; }
    }
    class ClasseAPI
    {
        var unirest = require("unirest");

        var req = unirest("GET", "https://amazon-price1.p.rapidapi.com/eanToAsin");

        req.query({
	"marketplace": "ES",
	"ean": "<REQUIRED>"
});

req.headers({
	"x-rapidapi-key": "e3a9ddf2d3mshdc71524468db118p1d82edjsnb5391767148e",
	"x-rapidapi-host": "amazon-price1.p.rapidapi.com",
	"useQueryString": true
});


req.end(function(res) {
    if (res.error) throw new Error(res.error);

    console.log(res.body);
});
    }
}
