import requests
import ssl
import json

try:
    _create_unverified_https_context = ssl._create_unverified_context
except AttributeError:
    pass
else:
    ssl._create_default_https_context = _create_unverified_https_context

def searchQuery():
    gameUrl = "https://localhost:44387/GameIdeas/api/getrandomfantasygame/123"   
    planetsPage = requests.request("GET", gameUrl, verify=False)
    return planetsPage

def jsonFormatter():
    return json.loads(json.dumps(searchQuery().json()))

