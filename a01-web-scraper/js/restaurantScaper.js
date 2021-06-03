const fetch = require('node-fetch')
const cheerio = require('cheerio')

const restaurantScraper = {
    loginToBooking: async function(url) {
        const getData = {
            method: 'Get'
        }
        const response = await fetch(url, getData)
        const data = await response.text()
        let $=cheerio.load(data)
        console.log($.html())
    }
}

module.exports.restaurantScraper = restaurantScraper