import { templateTemplatePage } from './app.po';

describe('template App', function() {
  let page: templateTemplatePage;

  beforeEach(() => {
    page = new templateTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
