$.validator.addMethod("customstringlength", function (value, element, params) {
    const minLength = parseInt(params[0], 10);
    const maxLength = parseInt(params[1], 10);
    const length = value ? value.length : 0;

    return this.optional(element) || (length >= minLength && length <= maxLength);
});

$.validator.unobtrusive.adapters.add("customstringlength", ["min", "max"], function (options) {
    options.rules["customstringlength"] = [options.params.min, options.params.max];
    options.messages["customstringlength"] = options.message;
});