using HangManSharp;
Backend _backend = new Backend();

Thread initThread = new Thread(_backend.getWord);