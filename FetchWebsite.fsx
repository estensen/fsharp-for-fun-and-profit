open System
open System.IO
open System.Net

let fetchUrl callback url =
    let req = WebRequest.Create(Uri(url))
    use res = req.GetResponse()
    use stream = res.GetResponseStream()
    use reader = new IO.StreamReader(stream)
    callback reader url

let parseAndPrint (reader : IO.StreamReader) url =
    let html = reader.ReadToEnd()
    let html1000 = html.Substring(0,1000)
    printfn "Downloaded %s. First 1000 is %s" url html1000
    html

let google = fetchUrl parseAndPrint "http://google.com"

