PreauthorizationService preauthorizationService = paymillContext.PreauthorizationService;

Preauthorization preauthorization = preauthorizationService.CreateWithTokenAsync(
        "098f6bcd4621d373cade4e832627b4f6",
        4200,
        "EUR",
        "description example"
).Result;
