def two_fer(name = "you"):
    if name.isspace():
        name = "you"
        
    return f"One for {name}, one for me."