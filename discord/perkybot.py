import discord
from jsonScraper import jsonFormatter

token = "MTAxNDU2NjUwNDA5NzkyMzE0Mg.Gb3eE_.Hg2ipgO2Op60HAAFhHg8NukFE6Zp26ZhHRGX2g"

pixelPlanetUrl = "https://app.pixelencounter.com/api/basic/planets?frame=1000&disableBackground=true&disableStars=true"
gameUrl = "https://localhost:44387/GameIdeas/api/getrandomfantasygame/123"

client = discord.Client(intents=discord.Intents.default())

@client.event
async def on_message(message):

    lore = jsonFormatter()

    if message.author == client.user:
        return

    if message.content.split(' ')[0] == '!perkyidea':
        query = message.content.replace('!perkyidea', '')

    embed = discord.Embed(
        title="Randomly generated planet!",
        url = pixelPlanetUrl
    )

    embed.set_thumbnail(
        url = gameUrl
    )
    embed.add_field(
        name = "Has asks",
        value = f"{product['market']['hasAsks']}"
    )
    embed.add_field(
        name = "Lowest ask & lowest ask size",
        value = f"Lowest ask: {product['market']['lowestAsk']} | Lowest ask size {product['market']['lowestAskSize']}"
    )

    embed.add_field(
        name = "Last sale & sale size",
        value = f"Sale: {product['market']['lastSale']} | Last sale size: {product['market']['lastSaleSize']}"
    )
    await message.channel.send(embed=embed)



client.run(token)


