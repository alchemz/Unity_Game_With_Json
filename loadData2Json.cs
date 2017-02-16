{\rtf1\ansi\ansicpg1252\cocoartf1404\cocoasubrtf470
{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
\margl1440\margr1440\vieww10800\viewh8400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0

\f0\fs24 \cf0 1. create a StreamingAssets folder\
2. put the data file there. with the Json code\
Q: should the datafile be a .json format?\
\
Serialization Deserialization\
Jason: Javascript format to output read data\
\
create GameData.cs\
[System.Serializable]\
public RoundData[] allRoundData;\
\
\
Inside DataController.cs\
using System.IO;\
private RoundData[] allRoundData;\
private string gameDataFileName =\'93data.json\'94;\
\
private void LoadGameData()\{\
	string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);\
	if(File.Exists(filePath)\
	\{\
		string dataAsJson = File.ReadAllText(filePath);\
		//deserialize\
		GameData loadedData = JsonUnility.FromJson<GameData>(dataAsJson);\
		allRoundData = loadedData.allRoundData;\
	\}else\{\
		Debug.LogError(\'93Cannot load game data!\'94);\
	\}\
\}}