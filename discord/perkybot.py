import discord
import requests
from jsonScraper import jsonFormatter

token = ""
 
gameUrl = "https://localhost:44387/GameIdeas/api/getrandomfantasygame/123"

client = discord.Client(intents=discord.Intents.default())

planetUrl = "https://app.pixelencounter.com/api/basic/planets?frame=1000&disableBackground=true&disableStars=true"



async def fetchImage():
    img_data = requests.get(planetUrl).content
    with open('worldImage.jpg', 'wb') as handler:
        handler.write(img_data)
        
@client.event
async def on_message(message):

    lore = jsonFormatter()
    image = fetchImage()
    file = discord.File("worldImage.jpg", filename="worldImage.jpg")
    
    if message.author == client.user:
        return

    if message.content.split(' ')[0] == '!perkylore':
        query = message.content.replace('!perkylore', '')

    embed = discord.Embed(
        title="Randomly generated lore!",
    )

    embed.set_thumbnail(url="attachment://worldImage.jpg")
    embed.add_field(
        name = "World name",
        value = f"{lore['gameWorld']['gameWorldName']}",
        inline=True
    )
    
    # Adding all of the characters as an embed, making sure the length is always the right value
    embed.add_field(
        name = f"{lore['gameCharacters'][0]['characterName']}",
        value = f"{lore['gameCharacters'][0]['characterLore']}",
        inline=False
    )
    embed.add_field(
        name = f"{lore['gameCharacters'][1]['characterName']}",
        value = f"{lore['gameCharacters'][1]['characterLore']}",
        inline=False
    )
    embed.add_field(
        name = f"{lore['gameCharacters'][2]['characterName']}",
        value = f"{lore['gameCharacters'][2]['characterLore']}",
        inline=False
    )
    await image
    await message.channel.send(file = file, embed=embed)



client.run(token)


