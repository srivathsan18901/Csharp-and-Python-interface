def addition(a, b):
    try:
        result = int(a) + int(b)
        return result
    except Exception as ex:
        # Handle exceptions appropriately
        return str(ex)

