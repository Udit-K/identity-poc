
        //     services.AddIdentityServer().AddSamlDynamicProvider(samlOptions => {
                
        //         samlOptions.Licensee = "DEMO";
        //         samlOptions.LicenseKey = "eyJTb2xkRm9yIjowLjAsIktleVByZXNldCI6NiwiU2F2ZUtleSI6ZmFsc2UsIkxlZ2FjeUtleSI6ZmFsc2UsImF1dGgiOiJERU1PIiwiZXhwIjoiMjAyMi0wMS0yOVQwMDowMDowMS43MjI3OTYrMDA6MDAiLCJpYXQiOiIyMDIxLTEyLTMwVDAwOjAwOjAxLjAwMDc5NiIsIm9yZyI6IkRFTU8iLCJhdWQiOjJ9.O/ezbhkzmFxGkhUDEgcIqNk5Rl+7TDgHNv2YAOWPwNXfgKvHJqT7Ch2swnXM0XxjYaqSlZAsOmXufsJhf6ibfGSyiY3SwRJdSU9TVXLDXlaxlBkAzx9jkSzZOXG9c/2k8oDcpL/HFPZwGndx6Y6OshOuqUwer4Srg0I3GHtQ2nQ2M6R8Z1N0WH/QECcx633H18mCEEVDcwf+ub7bDwSbtvntg0ptqIirqgwK4WmYXuh/eTwHM9gouS53WVI6sJIir/eDYWSS70gL9uWCl81cOvXoQdEEg5uLUQjBNuvSkPBdqryipFNRPcGM6BHRr+ipBiXMFtlYRvfXpds28+m6+ab+VcMtzICwygBzA4V/oGe35F4LWm4GZx4g9dPvuDkaJfI667ddewrxkwk8MTn8JCEe0pC9Nncc7qO8zWm3DzupjYOuP37x/DeX9zI33PIDJutcUUaDgS1PRGCa44aJMoSkpfynblBiZoPlpFni85gRMb5wgYVq2Gs/8ZheMOMqUgia+gjR80tnXohLT2GbdTZOX4v2/UG+JmqfK64nB/8Mv7IqjZkJOUPf/tJc65i6wAYSK700iBNlR50kwYcXl3EjEb8k6DEfIks4iO2CVfak3GV5jrmbwxsDG0Jx4QIxNvROMacCaF1rKaYzf3noHM8/91yjRtmBflvkIQQC1nw";
                
        //         samlOptions.NameIdClaimType = "sub";
        //         samlOptions.CallbackPath = "https://localshost:5001/saml";
        //         samlOptions.SignInScheme = "cookie";

        //        //idp specific options
        //         samlOptions.IdentityProviderMetadataAddress = "https://dev-411274.okta.com/app/exketzt7voh6Hec3K357/sso/saml/metadata"; 
        //         //To check if the incoming SAML information is coming correctly
        //         samlOptions.RequireValidMetadataSignature = false;
        //         //To check if data isn't outdated. 120 == 2 minutes
        //         samlOptions.TimeComparisonTolerance = 120;

        //         samlOptions.ServiceProviderOptions = new SpOptions
        //         {
        //             EntityId = "https://localhost:5001/saml",
        //             MetadataPath = "saml/metadata"
        //         };


        //     });



        // ////////////////////////////////////////////

        //     .AddSaml2p("cool app", options => {
        //         options.Licensee = "DEMO";
        //         options.LicenseKey = "eyJTb2xkRm9yIjowLjAsIktleVByZXNldCI6NiwiU2F2ZUtleSI6ZmFsc2UsIkxlZ2FjeUtleSI6ZmFsc2UsIlJlbmV3YWxTZW50VGltZSI6IjAwMDEtMDEtMDFUMDA6MDA6MDAiLCJhdXRoIjoiREVNTyIsImV4cCI6IjIwMjItMDEtMzBUMDE6MDA6MDAuNDk3MjA0NCswMDowMCIsImlhdCI6IjIwMjEtMTItMzFUMDE6MDA6MDAiLCJvcmciOiJERU1PIiwiYXVkIjoyfQ==.aiYeOa6e18f7YktrlXjl0ROWF7ni0NwbnqrGwww6kZC/OTCARa9yfbew7YAO9vhH4cyTFcr9o45VRWNpYL33m7JjCedWlaRbvx2yyMyHpvUCIzjgL927DXvQ9lu0UQOb6q8Fi5XyjCb1NqHoQdOhaO08h91Ip6A4OuiQjrpa4TsUg9QV0dcPqdPkkm1tEx14UG7X611NOch6kUDSL4IorTS3uBpGpCgj0UVwScTtyOYWweQK2/C1zZKvy6vZmx60Z6xYRws4YxqX+5y4p1fpyfcZ1ZFtCG0NFW1LpztYTgbiGodZoYzf3gd/MqdoCb/6uUfzOpGCBPjEuPvwqgFUgSL0lqSwdA2+z3vYDjKdBmI5T2f5lqglIig+BEvlSn2i0QL/foLh7EuckWOrFoKP08W4hFaFR/Z3XBXEtyNvxu1DpllrMWZjeRaa4WLkoaryGA0y2vvoFY4SstGljCDSuGJc2I6PoZ2SEb0x18Zip0aN7UllhprPlOijWGU/aYYLng+M87vLCZ940b+zp2dKsk9C3HMJB2nckV80YqlGIdXeRGW+vmiLPidJNhmsTdoJLauQ3KUpwxIinTkMuoVElO1Bv+CigNMgrshKY23PVAFw9A3z+FvbUg7EAXnce2RMLypguBceH5GSeMaG0+jqxam769yzztezJ+JFcQQorXc=";
        //         options.IdentityProviderMetadataAddress = idp.IdentityProviderMetadataAddress;
        //         options.RequireValidMetadataSignature = idp.RequireValidMetadataSignature;
        //         options.TimeComparisonTolerance = idp.TimeComparisonTolerance;
        //         var spo = idp.ServiceProviderOptions; 
        //         options.ServiceProviderOptions = new SpOptions
        //         {
        //             EntityId = spo.EntityId,
        //             MetadataPath = spo.MetaDataPath,
        //             SignAuthenticationRequests = spo.SignAuthenticationRequests
        //         };
        //         options.NameIdClaimType = idp.NameIdClaimType;
        //         options.CallbackPath = idp.CallbackPath;
        //         options.SignInScheme = idp.SignInScheme;

        //     })
        //     .AddFacebook(facebookOptions =>
        //     {
        //         facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
        //         facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
        //     });






