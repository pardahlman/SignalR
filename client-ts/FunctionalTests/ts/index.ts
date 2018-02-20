// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

console.log("SignalR Functional Tests Loaded");
document.write("<input type=\"hidden\" id=\"sentinel-signalr-functional-tests\" value=\"loaded\"></input>");

import "es6-promise/dist/es6-promise.auto.js";
import "./ConnectionTests";
import "./HubConnectionTests";
import "./WebDriverReporter";
import "./WebSocketTests";

(window as any).functionalTestsLoaded = true;
