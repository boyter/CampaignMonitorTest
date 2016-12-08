// Assumes that if we are using future world JS where some of these methods exist
// that we want to overwrite them anyway, hence not checking if they already exist

// Requirement 5
String.prototype.startsWith = function(str) {
  return this.substring(0, str.length) === str;
};

String.prototype.endsWith = function(str) {
  return this.substring(this.length - str.length, this.length) === str;
};

// Requirement 6
String.prototype.stripHtml = function () {
  // Sandbox http://www.regexpal.com/?fam=96086
  // Modifiers used g=global m=multiline
  return this.replace(/<(?:.|\n)*?>/gm, '');
};