# MQTT - Jimmy Pellizzer e Marco Del Sal

MQTT è un protocollo basato su un modello pubblicazione-sottoscrizione (pub/sub). Il client pubblica, il broker riceve e "distribuisce" a tutti i client sottoscritti.

La destinazione dei messaggi è il TOPIC, nel nostro caso "iot2024test/mio/". I messaggi inviati avranno la seguente formattazione: ($"Data sent: {sensor.Name()} = {sensorValue}"), verranno serializzati in json e infine il TOPIC verrà aggiornato con /sensor per una migliore distinzione tra TOPIC. Tutti i dati vengono salvati in un DB.

Un altro TOPIC che si potrebbe implementare è /comandi, in cui i messaggi inviati sarebbero dei comandi utili al controllo remoto del dispositivo (in questo caso la macchina).

Una funzione che non abbiamo implementato ma che potrebbe essere utile è il RetainFlag. I messaggi inviati prima della sottoscrizione non verranno ricevuti dal client, con l'utilizzo di RetainFlag si ha la possibilità di salvare un messaggio che verrà inviato immediatamente dopo la sottoscrizione.
Un'altra funzione relativa all'invio di un messaggio è Lastwillmessage, permette di impostare un messaggio che verrà inviato alla disconnessione di un client.
Un altro flag utile è KeepAlive, permette di impostare un tempo limite in cui non vengono scambiati messaggi prima di chiudere la sessione.
