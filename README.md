# dotnet-regex 
[![Join the chat at https://gitter.im/nnCron/nnCron](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/nnCron/nnCron?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

dotnet regex plugin for nnCron

## Install

* Copy `re\re\bin\Release\re.dll` to nncron home directory nnCron
* Copy `re.spf` to `nnCron\plugins`
* Add `re.spf` into plugins list in nnCron.ini or via GUI

## Manual

### dll

* [Debug](re/doc/Debug.md)
* [Release](re/doc/Debug.md)

Doc xml2md generator:  https://gist.github.com/VoidVolker/d195b9746fcc6907a551

### Regex class

https://msdn.microsoft.com/en-us/library/system.text.regularexpressions.regex(v=vs.110).aspx

### Plugin

(In develop)

---

## Установка

* Копировать `re\re\bin\Release\re.dll` в домашний каталог nnCron
* Копировать `re.spf` в каталог `nnCron\plugins`
* Добавить `re.spf` в список плагинов в `nnCron.ini` или через GUI

## Докуменатция 

### dll

* [Debug](re/doc/Debug.md)
* [Release](re/doc/Debug.md)

Документация генерируется из xml комментариев вот этой программой: https://gist.github.com/VoidVolker/d195b9746fcc6907a551
Поэтому вносить правки следует в комментарии в файлах исходного кода. Фактически большей частью - копипаст msdn.

### Регулярные выражения

https://msdn.microsoft.com/ru-ru/library/system.text.regularexpressions.regex(v=vs.110).aspx

### Плагин

(В разработке)

