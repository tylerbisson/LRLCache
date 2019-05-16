Rails.application.routes.draw do
  get 'users/index'
  resources :users, only: [:show]
  devise_for :users
  get '/get_current_user', to: 'users#get_current_user'
  # For details on the DSL available within this file, see http://guides.rubyonrails.org/routing.html
  namespace :api, defaults: {format: :json} do
    resources :records, only: [:create, :index, :show, :update, :destroy]
  end
  root "static_pages#root"
end

